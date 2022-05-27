using DesafioSoftplan.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAsync();

        Task<UserDto> GetAsync(int id);

        Task<UserDto> SaveAsync(UserDto obj);

        Task DeleteAsync(int id);
    }
}