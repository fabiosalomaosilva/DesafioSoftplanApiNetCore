using DesafioSoftplan.Contracts;
using DesafioSoftplan.Domain.Entities;
using DesafioSoftplan.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            var user = await Task.Run(() => _dbContext.Set<User>().SingleOrDefault(x => x.Email == email && x.Password == Encript(password)));

            if (user == null)
                return null;

            return WithoutPassword(user);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await Task.Run(() => _dbContext.Set<User>().ToList());
            return WithoutPasswords(users);
        }

        private IEnumerable<User> WithoutPasswords(IEnumerable<User> users) => users.Select(x => WithoutPassword(x));
        private User WithoutPassword(User user)
        {
            user.Password = null;
            return user;
        }
        public string Encript(string senha)
        {
            string valorRetorno;

            using (var hash = SHA1.Create())
            {
                var bytes = Encoding.ASCII.GetBytes(senha);
                var data = hash.ComputeHash(bytes);
                var s = new StringBuilder();

                foreach (byte t in data)
                {
                    s.Append(t.ToString("X2"));
                }
                valorRetorno = s.ToString();
            }
            return valorRetorno;
        }
    }
}