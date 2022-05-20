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

        /// <summary>
        /// Anchor that links the relationship with Discount
        /// </summary>
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        /// <summary>
        /// Anchor that links the relationship with Category
        /// </summary>
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        /// <summary>
        /// Anchor that links the relationship with Inventory
        /// </summary>
        public int ProductInventoryId { get; set; }
        public ProductInventory ProductInventory { get; set; }

        /// <summary>
        /// Unique key to communicate between microservices
        /// </summary>
        public string ProductoGuid { get; set; }
    }
}
