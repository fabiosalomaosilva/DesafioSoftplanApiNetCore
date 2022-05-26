using DesafioSoftplan.Contracts;
using DesafioSoftplan.Infra.Data.Context;
using DesafioSoftplan.Infra.Data.Repositories;
using DesafioSoftplan.Services.Dtos;
using DesafioSoftplan.Services.Interfaces;
using DesafioSoftplan.Services.Mappings;
using DesafioSoftplan.Services.Services;
using DesafioSoftplan.Services.Validation;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioSoftplan.Infra.Ioc
{
    public static class DependencyInjectionContainer
    {
        public static void AddContainerDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("connectiondb")));
            services.AddAutoMapper(typeof(DtoToEntityMapper), typeof(EntityToDtoMapper));



            //Repositories
            services.AddScoped<ICountryRepository, CountryRepositorio>();
            services.AddScoped<ICountryRepository, CountryRepositorio>();

            //Services
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICountryService, CountryService>();

            //Validations
            services.AddScoped<IValidator<UserDto>, UserValidator>();
            services.AddScoped<IValidator<CountryDto>, CountryValidator>();
        }
    }
}
