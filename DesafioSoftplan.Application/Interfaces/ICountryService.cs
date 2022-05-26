using DesafioSoftplan.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAsync();

        Task<CountryDto> GetAsync(int id);

        Task<CountryDto> AddAsync(CountryDto obj);

        Task<CountryDto> EditAsync(CountryDto obj);

        Task DeleteAsync(int id);
    }
}