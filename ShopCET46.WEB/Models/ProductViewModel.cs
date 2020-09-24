using Microsoft.AspNetCore.Http;
using ShopCET46.WEB.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace ShopCET46.WEB.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }


    }
}
