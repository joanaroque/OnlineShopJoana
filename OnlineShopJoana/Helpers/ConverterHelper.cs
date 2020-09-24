using OnlineShopJoana.WEB.Data.Entities;
using OnlineShopJoana.WEB.Models;
using System;

namespace OnlineShopJoana.WEB.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Product ToProduct(ProductViewModel model, string path, bool isNew)
        {
            return new Product
            {
                Id = isNew ? 0 : model.Id, //porque pode vir do create ou do edit
                ImageUrl = path,
                IsAvailable = model.IsAvailable,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
                User = model.User
            };
        }

        public ProductViewModel ToProductViewModel(Product model)
        {
            return new ProductViewModel
            {
                Id = model.Id,
                ImageUrl = model.ImageUrl,
                IsAvailable = model.IsAvailable,
                LastPurchase = model.LastPurchase,
                LastSale = model.LastSale,
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock,
                User = model.User
            };
        }
    }
}
