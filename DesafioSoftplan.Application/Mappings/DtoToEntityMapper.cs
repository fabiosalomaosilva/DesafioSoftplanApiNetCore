using AutoMapper;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;

namespace DesafioSoftplan.Services.Mappings
{
    public class DtoToEntityMapper : Profile
    {
        public DtoToEntityMapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<Country, CountryDto>();
        }
    }
}