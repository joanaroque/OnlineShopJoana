using Microsoft.AspNetCore.Http;
using OnlineShopJoana.WEB.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopJoana.WEB.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }


    }
}
