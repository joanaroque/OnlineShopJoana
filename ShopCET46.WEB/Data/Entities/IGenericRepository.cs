using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Data
{
    public interface IGenericRepository<T> where T : class //para qualquer class
    {
        //trabalha com os valores que vêm da tabela

        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(int id);
    }
}