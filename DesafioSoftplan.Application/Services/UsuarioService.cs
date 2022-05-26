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
            var User = await _UserRepository.GetAsync(id);
            return _mapper.Map<UserDto>(User);
        }

        public async Task<UserDto> AddAsync(UserDto obj)
        {
            var User = _mapper.Map<User>(obj);
            await _UserRepository.AddAsync(User);
            return _mapper.Map<UserDto>(User);
        }

        public async Task<UserDto> EditAsync(UserDto obj)
        {
            var User = _mapper.Map<User>(obj);
            await _UserRepository.EditAsync(User);
            return _mapper.Map<UserDto>(User);
        }

        public async Task DeleteAsync(int id)
        {
            await _UserRepository.DeleteAsync(id);
        }
    }

}