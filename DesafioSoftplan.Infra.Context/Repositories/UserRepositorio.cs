using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Infra.Data.Context;

namespace DesafioSoftplan.Infra.Data.Repositories
{
    public class UserRepositorio : Repository<User>, IUserRepository
    {
        public UserRepositorio(DataContext dbContext) : base(dbContext)
        {
        }
    }
}