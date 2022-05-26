using AutoMapper;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;

namespace DesafioSoftplan.Services.Mappings
{
    public class EntityToDtoMapper : Profile
    {
        public EntityToDtoMapper()
        {
            CreateMap<UserDto, User>();
            CreateMap<CountryDto, Country>();
        }
    }
}