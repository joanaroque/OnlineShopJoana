using System;
using System.ComponentModel.DataAnnotations;

namespace ShopCET46.WEB.Data.Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }

        [MaxLength(50, ErrorMessage ="The field {0} only can contains {1} characters length.")]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }//C currency

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Avalible?")]
        public bool IsAvalible { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }//N number
        int IEntity.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
