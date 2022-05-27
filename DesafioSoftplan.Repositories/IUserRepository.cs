using DesafioSoftplan.Domain.Entities;
using System.Threading.Tasks;

namespace DesafioSoftplan.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> Authenticate(string email, string password);
    }
}