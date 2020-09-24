using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopCET46.WEB.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ShopCET46.WEB.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    { //tem que herdar á mesma aqui o interface, 
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            //buscar os users dos produtos
            return _context.Products.Include(p => p.User);
        }

        public IEnumerable<SelectListItem> GetComboProducts()
        {
            //criar a lista com os produtos todos
            var list = _context.Products.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).ToList();

            //criar outro item decorativo
            list.Insert(0, new SelectListItem
            {
                Text = "(Select a product...)",
                Value = "0"
            });

            return list;
        }
    }
}
