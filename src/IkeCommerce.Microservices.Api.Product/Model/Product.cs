using System;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string SKU { get; set; }
        public int CategoryId { get; set; }
        public int InventoryId { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Anchor that links the relationship with Discount
        /// </summary>
        public int ProductDiscountId { get; set; }
        //public ProductDiscount ProductDiscount { get; set; }

        /// <summary>
        /// Anchor that links the relationship with Category
        /// </summary>
        public int ProductCategoryId { get; set; }
        //public ProductCategory ProductCategory { get; set; }

        /// <summary>
        /// Anchor that links the relationship with Inventory
        /// </summary>
        public int ProductInventoryId { get; set; }
        //public ProductInventory ProductInventory { get; set; }

        /// <summary>
        /// Unique key to communicate between microservices
        /// </summary>
        public string ProductGuid { get; set; }
    }
}
