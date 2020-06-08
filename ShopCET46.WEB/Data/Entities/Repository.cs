using ShopCET46.WEB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Data
{
    public class Repository : IRepository
    //CRUD pra BD
    {
        private readonly DataContext _context;

        public Repository(DataContext context) // injeçao
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts() //vai buscar os produtos todos
        {
            return _context.Products.OrderBy(p => p.Name);
        }

        public Product GetProduct(int id) // vai buscar so um produto
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }

        public void RemoveProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public async Task<bool> SaveAllAsync()
        {
            //vai á BD gravar todas as alteraçoes
            //se este nr for maior que 0 retorna true
            //ou seja se as mudanças foram 0, nao salva nada
            return await _context.SaveChangesAsync() > 0;
        }

        public bool ProductExists(int id)
        {
            return _context.Products.Any(p => p.ProductId == id);
        }
    }
}
