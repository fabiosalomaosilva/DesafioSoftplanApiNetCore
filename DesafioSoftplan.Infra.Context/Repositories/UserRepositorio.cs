using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Infra.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Infra.Data.Repositories
{
    public class UserRepositorio : Repository<User>, IUserRepository
    {
        private DataContext _dbContext;

        public UserRepositorio(DataContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Authenticate(string email, string password)
        {
            var user = await Task.Run(() => _dbContext.Set<User>().SingleOrDefault(x => x.Email == email && x.Password == password));

            if (user == null)
                return null;

            return user;
        }
    }
}