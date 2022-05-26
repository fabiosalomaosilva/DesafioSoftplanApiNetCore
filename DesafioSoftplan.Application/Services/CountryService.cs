using AutoMapper;
using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _CountryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository CountryRepository, IMapper mapper)
        {
            _CountryRepository = CountryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountryDto>> GetAsync()
        {
            var listaCountrys = await _CountryRepository.GetAsync();
            return _mapper.Map<IEnumerable<CountryDto>>(listaCountrys);
        }

        public async Task<CountryDto> GetAsync(int id)
        {
            var Country = await _CountryRepository.GetAsync(id);
            return _mapper.Map<CountryDto>(Country);
        }

        public async Task<CountryDto> AddAsync(CountryDto obj)
        {
            var Country = _mapper.Map<Country>(obj);
            await _CountryRepository.AddAsync(Country);
            return _mapper.Map<CountryDto>(Country);
        }

        public async Task<CountryDto> EditAsync(CountryDto obj)
        {
            var Country = _mapper.Map<Country>(obj);
            await _CountryRepository.EditAsync(Country);
            return _mapper.Map<CountryDto>(Country);
        }

        public async Task DeleteAsync(int id)
        {
            await _CountryRepository.DeleteAsync(id);
        }
    }

}