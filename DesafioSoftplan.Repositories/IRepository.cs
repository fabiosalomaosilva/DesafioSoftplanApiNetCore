using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioSoftplan.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync();

        Task<T> GetAsync(int id);

        Task<T> AddAsync(T obj);

        Task<T> EditAsync(T obj);

        Task DeleteAsync(int obj);
    }
}