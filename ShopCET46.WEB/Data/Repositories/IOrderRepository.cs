using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        //vai buscar todas as encomendas criadas por um user
        Task<IQueryable<Order>> GetOrdersAsync(string userName);

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);


        Task AddItemToOrderAsync(AddItemViewModel model, string userName);


        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

    }
}
