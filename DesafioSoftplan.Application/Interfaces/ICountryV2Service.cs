using DesafioSoftplan.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Interfaces
{
    public interface ICountryV2Service
    {
        Task<IEnumerable<CountryV2Dto>> GetAsync();

        Task<CountryV2Dto> GetAsync(int id);

        Task<CountryV2Dto> AddAsync(CountryV2Dto obj);

        Task<CountryV2Dto> EditAsync(CountryV2Dto obj);

        Task DeleteAsync(int id);
    }
}