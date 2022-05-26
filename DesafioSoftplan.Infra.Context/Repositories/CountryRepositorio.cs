using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Infra.Data.Context;

namespace DesafioSoftplan.Infra.Data.Repositories
{
    public class CountryRepositorio : Repository<Country>, ICountryRepository
    {
        public CountryRepositorio(DataContext dbContext) : base(dbContext)
        {
        }
    }
}