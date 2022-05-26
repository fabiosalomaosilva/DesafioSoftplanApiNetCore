using DesafioSoftplan.Services.Dtos;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserInfoDto> Authenticate(LoginDto login);

        Task Register(RegisterDto register);
    }
}