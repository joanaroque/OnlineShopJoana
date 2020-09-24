using System;
using System.ComponentModel.DataAnnotations;

namespace ShopCET46.WEB.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

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
        public bool IsAvailable { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }//N number


        public User User { get; set; }


        public string ImageFullPath 
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }
                return $"https://shopcet46joana.azurewebsites.net{this.ImageUrl.Substring(1)}"; //substring para tirar o ~
            }
        }


        public User CreatedBy { get; set; }


        public DateTime CreateDate { get; set; }


        public DateTime UpdateDate { get; set; }


        public User ModifiedBy { get; set; }
    }
}
