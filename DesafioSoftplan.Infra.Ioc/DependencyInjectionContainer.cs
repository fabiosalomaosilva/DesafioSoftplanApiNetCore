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
                opt.UseNpgsql(configuration.GetConnectionString("connectiondb")));

            services.AddAutoMapper(typeof(DtoToEntityMapper), typeof(EntityToDtoMapper));

            //Repositories
            services.AddScoped<IUserRepository, UserRepositorio>();
            services.AddScoped<ICountryRepository, CountryRepositorio>();
            services.AddScoped<ICountryRepository, CountryRepositorio>();

            //Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICountryV2Service, CountryV2Service>();

            //Validations
            services.AddScoped<IValidator<UserDto>, UserValidator>();
            services.AddScoped<IValidator<CountryDto>, CountryValidator>();
            services.AddScoped<IValidator<CountryV2Dto>, CountryV2Validator>();
        }
    }
}
