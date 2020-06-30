namespace ShopCET46.Common.Models
{
    public class ProductResponse
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public decimal Price { get; set; }


        public string ImageUrl { get; set; }


        public object LastPurchase { get; set; }


        public object LastSale { get; set; }


        public bool IsAvalible { get; set; }


        public double Stock { get; set; }


        public UserResponse User { get; set; }


        public string ImageFullPath { get; set; }
    }
}
