using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ShopCET46.WEB.Data.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }



        [Required]
        [DisplayName("Order date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime OrderDate { get; set; }



        [DisplayName("Delivery date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? DeliveryDate { get; set; }



        [Required]
        public User User { get; set; }



        public IEnumerable<OrderDetail> Items { get; set; }




        [DisplayFormat(DataFormatString = "{0:N2}")]
        public int Lines { get { return Items == null ? 0 : Items.Count(); } }



        [DisplayFormat(DataFormatString = "{0:N2}")]
        public double Quantity => Items == null ? 0 : Items.Sum(i => i.Quantity);



        public decimal Value => Items == null ? 0 : Items.Sum(i => i.Value);


        [DisplayName("Order date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? OrderDateLocal
        {
            get
            {
                if (OrderDate == null)
                {
                    return null;
                }

                return OrderDate.ToLocalTime();
            }
        }

        public User CreatedBy { get; set; }



        public DateTime CreateDate { get; set; }



        public DateTime UpdateDate { get; set; }



        public User ModifiedBy { get; set; }
    }
}
