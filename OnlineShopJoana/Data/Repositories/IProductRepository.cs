using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using OnlineShopJoana.WEB.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopJoana.WEB.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers(); //todos os produtos + users

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
    