using ShopCET46.WEB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;
        private Random _random;


        public SeedDB(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync() //metodos async acabam todos com Async no fim do nome
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Products.Any()) 
            {
                this.AddProduct("Boné oficial slb");
                this.AddProduct("Cueca oficial slb");
                this.AddProduct("Biquini oficial slb");

                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(500),
                IsAvalible = true,
                Stock = _random.Next(1000)
            });

        }
    }
}
