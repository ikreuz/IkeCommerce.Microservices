using System;
using System.Collections.Generic;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        /// <summary>
        /// Establishes the one-to-many relationship
        /// </summary>
        public ICollection<Product> ProductList { get; set; }
    }
}
