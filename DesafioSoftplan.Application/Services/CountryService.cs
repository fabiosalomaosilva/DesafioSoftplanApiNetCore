using AutoMapper;
using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{
    public class CountryService : ServiceBase, ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository CountryRepository, IMapper mapper) :
        base(mapper) => _countryRepository = CountryRepository;

        public async Task<IEnumerable<CountryDto>> GetAsync()
        {
            var listaCountrys = await _countryRepository.GetAsync();
            return _mapper.Map<IEnumerable<CountryDto>>(listaCountrys);
        }

        public async Task<CountryDto> GetAsync(int id)
        {
            var country = await _countryRepository.GetAsync(id);
            return _mapper.Map<CountryDto>(country);
        }

        public async Task<CountryDto> AddAsync(CountryDto obj)
        {
            try
            {
                var country = new Country();
                var response = string.Empty;
                var respCode = await _client.GetAsync($"/v3.1/alpha/{obj.Code}");
                if (respCode.IsSuccessStatusCode)
                {
                    response = JsonConvert.SerializeObject(await respCode.Content.ReadAsStringAsync());
                }
                else
                {
                    var respNome = await _client.GetAsync($"/v3.1/name/{obj.Name}");
                    if (respNome.IsSuccessStatusCode)
                    {
                        response = JsonConvert.SerializeObject(await respNome.Content.ReadAsStringAsync());
                    }
                }

                if (!string.IsNullOrEmpty(country.JsonInfo))
                {
                    var countryResponse = JsonConvert.DeserializeObject<ResCoutriesDto[]>(response)[0];

                    obj.Name = countryResponse.name.common;
                    obj.Capital = countryResponse.capital[0];
                    obj.Code = countryResponse.cca2;
                    obj.Area = countryResponse.area;
                    obj.DemographicDensity = obj.Population / obj.Area;
                };

                country = _mapper.Map<Country>(obj);
                await _countryRepository.AddAsync(country);
                return _mapper.Map<CountryDto>(country);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CountryDto> EditAsync(CountryDto obj)
        {
            var country = new Country();
            var response = string.Empty;
            var respCode = await _client.GetAsync($"/v3.1/alpha/{obj.Code}");
            if (respCode.IsSuccessStatusCode)
            {
                response = JsonConvert.SerializeObject(await respCode.Content.ReadAsStringAsync());
            }
            else
            {
                var respNome = await _client.GetAsync($"/v3.1/name/{obj.Name}");
                if (respNome.IsSuccessStatusCode)
                {
                    response = JsonConvert.SerializeObject(await respNome.Content.ReadAsStringAsync());
                }
            }

            if (!string.IsNullOrEmpty(response))
            {
                var countryResponse = JsonConvert.DeserializeObject<ResCoutriesDto[]>(response)[0];

                obj.Name = countryResponse.name.common;
                obj.Capital = countryResponse.capital[0];
                obj.Code = countryResponse.cca2;
                obj.Area = countryResponse.area;
                obj.DemographicDensity = obj.Population / obj.Area;
            };

            country = _mapper.Map<Country>(obj);
            await _countryRepository.EditAsync(country);
            return _mapper.Map<CountryDto>(country);
        }

        public async Task DeleteAsync(int id)
        {
            await _countryRepository.DeleteAsync(id);
        }
    }
}
