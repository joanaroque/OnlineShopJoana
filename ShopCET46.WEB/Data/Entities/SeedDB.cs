using Microsoft.AspNetCore.Identity;
using ShopCET46.WEB.Data.Entities;
using ShopCET46.WEB.Helpers;
using System;
using System.Collections.Generic;
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

            await _userHelper.ChecRoleAsync("Admin");
            await _userHelper.ChecRoleAsync("Customer");


            if (!_context.Cities.Any())
            {
                var cities = new List<City>();
                cities.Add(new City { Name = "Lisboa" });
                cities.Add(new City { Name = "Porto" });
                cities.Add(new City { Name = "Coimbra" });
                cities.Add(new City { Name = "Porto" });

                _context.Countries.Add(new Country
                {
                    Cities = cities,
                    Name = "Portugal"
                });

                await _context.SaveChangesAsync();
            }

            var user = await _userHelper.GetUserByEmailAsync("joanatpsi@gmail.com");

            if (user == null)
            {
                user = new User
                {
                    FirstName = "Joana",
                    LastName = "Roque",
                    Email = "joanatpsi@gmail.com",
                    UserName = "joanatpsi@gmail.com",
                    PhoneNumber = "156456456",
                    Adress = "Rua Jau",
                    CityId = _context.Countries.FirstOrDefault()
                    .Cities.FirstOrDefault().Id,
                    City = _context.Countries.FirstOrDefault()
                    .Cities.FirstOrDefault()
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
               
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder.");
                }

                //gerar token e responder
                var token = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                await _userHelper.ConfirmEmailAsync(user, token);


                var isInRole = await _userHelper.IsUserInRoleAsync(user, "Admin");

                if (!isInRole)
                {
                    await _userHelper.AddUSerToRoleAsync(user, "Admin");
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
                IsAvailable = true,
                Stock = _random.Next(1000),
                User = user
            });

        }
    }
}
