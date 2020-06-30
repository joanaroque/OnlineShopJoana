using Microsoft.EntityFrameworkCore;
using ShopCET46.WEB.Data.Entities;
using System.Linq;

namespace ShopCET46.WEB.Data
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
    }
}
