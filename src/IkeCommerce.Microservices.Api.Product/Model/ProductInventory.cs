using System;
using System.Collections.Generic;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class ProductInventory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedA { get; set; }


        public ICollection<Product> ProductList { get; set; }
        public string ProductInventoryGuid { get; set; }
    }
}
