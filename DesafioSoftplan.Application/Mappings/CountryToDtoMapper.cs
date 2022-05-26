using AutoMapper;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using Newtonsoft.Json;

namespace DesafioSoftplan.Services.Mappings
{
    public class EntityToDtoMapper : Profile
    {
        public EntityToDtoMapper()
        {
            CreateMap<UserDto, User>();
            CreateMap<RegisterDto, User>();
            CreateMap<CountryDto, Country>()
                .ForMember(x => x.JsonInfo, m => { m.MapFrom(s => JsonConvert.SerializeObject(s)); });

            CreateMap<CountryV2Dto, Country>()
                .ForMember(x => x.JsonInfo, m => { m.MapFrom(s => JsonConvert.SerializeObject(s)); });
        }
    }
}