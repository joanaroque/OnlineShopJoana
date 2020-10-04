using Microsoft.AspNetCore.Identity;
using OnlineShopJoana.WEB.Data.Entities;
using OnlineShopJoana.WEB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopJoana.WEB.Data
{
    public class SeedDB
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private Random _random;


        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            _userHelper = userHelper;
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await CheckOrCreateRoles();

            await FillUserAsync();
            await FillProductsAsync();

        }

        private async Task FillProductsAsync()
        {
            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product
                {
                    Name = "Cato",
                    Price = _random.Next(500),
                    ImageUrl = ("~/images/Products/45.png"),
                    LastPurchase = DateTime.Now.AddDays(-12),
                    LastSale = DateTime.Now.AddDays(-3),
                    IsAvailable = true,
                    Stock = _random.Next(1000),
                    User = _context.Users.FirstOrDefault(),
                    CreateDate = DateTime.Now.AddDays(6),
                    CreatedBy = _context.Users.FirstOrDefault()

                });

                _context.Products.Add(new Product
                {
                    Name = "Tulipa",
                    Price = _random.Next(150),
                    ImageUrl = ("~/images/Products/46.png"),
                    LastPurchase = DateTime.Now.AddDays(-3),
                    LastSale = DateTime.Now.AddDays(-55),
                    IsAvailable = true,
                    Stock = _random.Next(999),
                    User = _context.Users.FirstOrDefault(),
                    CreateDate = DateTime.Now.AddDays(6),
                    CreatedBy = _context.Users.FirstOrDefault()

                });

                _context.Products.Add(new Product
                {
                    Name = "Margarida",
                    Price = _random.Next(250),
                    ImageUrl = ("~/images/Products/47.png"),
                    LastPurchase = DateTime.Now.AddDays(-2),
                    LastSale = DateTime.Now.AddDays(-25),
                    IsAvailable = true,
                    Stock = _random.Next(857),
                    User = _context.Users.FirstOrDefault(),
                    CreateDate = DateTime.Now.AddDays(6),
                    CreatedBy = _context.Users.FirstOrDefault()

                });

                _context.Products.Add(new Product
                {
                    Name = "Aloevera",
                    Price = _random.Next(154),
                    ImageUrl = ("~/images/Products/48.png"),
                    LastPurchase = DateTime.Now.AddDays(-44),
                    LastSale = DateTime.Now.AddDays(-12),
                    IsAvailable = true,
                    Stock = _random.Next(964),
                    User = _context.Users.FirstOrDefault(),
                    CreateDate = DateTime.Now.AddDays(6),
                    CreatedBy = _context.Users.FirstOrDefault()

                });

                _context.Products.Add(new Product
                {
                    Name = "Espada de São Jorge",
                    Price = _random.Next(444),
                    ImageUrl = ("~/images/Products/49.png"),
                    LastPurchase = DateTime.Now.AddDays(-4),
                    LastSale = DateTime.Now.AddDays(-5),
                    IsAvailable = true,
                    Stock = _random.Next(787),
                    User = _context.Users.FirstOrDefault(),
                    CreateDate = DateTime.Now.AddDays(6),
                    CreatedBy = _context.Users.FirstOrDefault()

                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task FillUserAsync()
        {
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
                    Address = "Rua Jau"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder.");
                }

                var token = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                await _userHelper.ConfirmEmailAsync(user, token);


                var isInRole = await _userHelper.IsUserInRoleAsync(user, "Admin");

                if (!isInRole)
                {
                    await _userHelper.AddUSerToRoleAsync(user, "Admin");
                }
            }
        }

        private async Task CheckOrCreateRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Customer");
        }

    }
}

