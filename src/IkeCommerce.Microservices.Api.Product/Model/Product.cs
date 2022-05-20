using System;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string SKU { get; set; }
        public int Category_Id { get; set; }
        public int Inventory_Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Modified_At { get; set; }
        public DateTime Deleted_At { get; set; }


        public int DiscountId { get; set; }
        public Discount Discount { get; set; }


        public int ProductInventoryId { get; set; }
        public ProductInventory ProductInventory { get; set; }


        public string ProductoGuid { get; set; }
    }
}
