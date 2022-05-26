using AutoMapper;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Services.Dtos;
using Newtonsoft.Json;

namespace DesafioSoftplan.Services.Mappings
{
    public class DtoToEntityMapper : Profile
    {
        public DtoToEntityMapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserInfoDto>();
            
            CreateMap<Country, CountryDto>()
                .ForMember(x => x.Id, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryDto>(s.JsonInfo).Id); })
                .ForMember(x => x.Name, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryDto>(s.JsonInfo).Name); })
                .ForMember(x => x.Area, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryDto>(s.JsonInfo).Area); })
                .ForMember(x => x.DemographicDensity, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryDto>(s.JsonInfo).DemographicDensity); })
                .ForMember(x => x.Capital, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryDto>(s.JsonInfo).Capital); })
                .ForMember(x => x.Population, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryDto>(s.JsonInfo).Population); });
            
            CreateMap<Country, CountryV2Dto>()
                .ForMember(x => x.Id, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).Id); })
                .ForMember(x => x.Name, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).Name); })
                .ForMember(x => x.Area, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).Area); })
                .ForMember(x => x.DemographicDensity, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).DemographicDensity); })
                .ForMember(x => x.Capital, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).Capital); })
                .ForMember(x => x.OfficialLanguages, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).OfficialLanguages); })
                .ForMember(x => x.Flag, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).Flag); })
                .ForMember(x => x.Population, m => { m.MapFrom(s => JsonConvert.DeserializeObject<CountryV2Dto>(s.JsonInfo).Population); });
        }
    }
}