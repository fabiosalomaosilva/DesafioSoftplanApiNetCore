using AutoMapper;
using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;

        public AuthService(IUserRepository UserRepository, IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public async Task<UserInfoDto> Authenticate(LoginDto login)
        {
            var user = await _UserRepository.Authenticate(login.Email, login.Password.ToEncript());
            return _mapper.Map<UserInfoDto>(user);

        }

        public async Task Register(RegisterDto register)
        {
            var password = register.Password.ToEncript();
            register.Password = password;
            var user = _mapper.Map<User>(register);
            await _UserRepository.AddAsync(user);
        }
    }

}