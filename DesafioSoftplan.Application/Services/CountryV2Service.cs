using AutoMapper;
using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{
    public class CountryV2Service : ServiceBase, ICountryV2Service
    {
        private readonly ICountryRepository _countryRepository;

        public CountryV2Service(ICountryRepository CountryRepository, IMapper mapper) :
        base(mapper) => _countryRepository = CountryRepository;

        public async Task<IEnumerable<CountryV2Dto>> GetAsync()
        {
            var listaCountrys = await _countryRepository.GetAsync();
            return _mapper.Map<IEnumerable<CountryV2Dto>>(listaCountrys);
        }

        public async Task<CountryV2Dto> GetAsync(int id)
        {
            var country = await _countryRepository.GetAsync(id);
            return _mapper.Map<CountryV2Dto>(country);
        }

        public async Task<CountryV2Dto> AddAsync(CountryV2Dto obj)
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
            await _countryRepository.AddAsync(country);
            return _mapper.Map<CountryV2Dto>(country);
        }

        public async Task<CountryV2Dto> EditAsync(CountryV2Dto obj)
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
            return _mapper.Map<CountryV2Dto>(country);
        }


        public async Task DeleteAsync(int id)
        {
            await _countryRepository.DeleteAsync(id);
        }
    }
}