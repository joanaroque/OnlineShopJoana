using ShopCET46.WEB.Data.Entities;
using System.Linq;

namespace ShopCET46.WEB.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers(); //todos os produtos + users
    }
}
