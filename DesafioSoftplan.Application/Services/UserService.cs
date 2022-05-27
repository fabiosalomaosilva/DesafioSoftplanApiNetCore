using AutoMapper;
using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository UserRepository, IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDto>> GetAsync()
        {
            var listaUsers = await _UserRepository.GetAsync();
            return _mapper.Map<IEnumerable<UserDto>>(listaUsers);
        }

        public async Task<UserDto> GetAsync(int id)
        {
            var user = await _UserRepository.GetAsync(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> SaveAsync(UserDto obj)
        {
            var exists = await _UserRepository.GetByEmailAsync(obj.Email);
            var user = _mapper.Map<User>(obj);
            if (exists != null && string.IsNullOrEmpty(exists.Email))
            {
                await _UserRepository.EditAsync(user);
                return _mapper.Map<UserDto>(user);
            }
            else
            {
                await _UserRepository.AddAsync(user);
                return _mapper.Map<UserDto>(user);
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _UserRepository.DeleteAsync(id);
        }
    }
}