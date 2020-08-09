using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using ShopCET46.WEB.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ShopCET46.WEB.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers(); //todos os produtos + users

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
    