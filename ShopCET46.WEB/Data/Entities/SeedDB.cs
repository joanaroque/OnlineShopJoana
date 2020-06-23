using Microsoft.AspNetCore.Identity;
using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.WEB.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;//responsavel pela autentiticaçao dos users
        private Random _random;


        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            _userHelper = userHelper;
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync() //metodos async acabam todos com Async no fim do nome
        {
            await _context.Database.EnsureCreatedAsync();

            //criar aqui user
            var user = await _userHelper.GetUserByEmailAsync("joana.ramos.roque@formandos.cinel.pt");

            if (user == null)
            {
                user = new User
                {
                    FirstName = "Joana",
                    LastName = "Roque",
                    Email = "joana.ramos.roque@formandos.cinel.pt",
                    UserName = "joana.ramos.roque@formandos.cinel.pt",
                    PhoneNumber = "156456456"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder.");
                }
            }

            if (!_context.Products.Any())
            {
                this.AddProduct("Boné oficial slb", user);
                this.AddProduct("Cueca oficial slb", user);
                this.AddProduct("Biquini oficial slb", user);

                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _random.Next(500),
                IsAvalible = true,
                Stock = _random.Next(1000),
                User = user
            });

        }
    }
}
