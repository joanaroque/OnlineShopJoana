using ShopCET46.WEB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    { //tem que herdar á mesma aqui o interface, 
        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}
