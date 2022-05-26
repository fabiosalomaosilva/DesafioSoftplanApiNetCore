using DesafioSoftplan.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAsync();

        Task<UserDto> GetAsync(int id);

        Task<UserDto> AddAsync(UserDto obj);

        Task<UserDto> EditAsync(UserDto obj);

        Task DeleteAsync(int id);

        Task<UserDto> Authenticate(string email, string password);

    }
}