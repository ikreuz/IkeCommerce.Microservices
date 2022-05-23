using System;
using System.Collections.Generic;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class ProductDiscount
    {
        public int ProductDiscountId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public decimal DiscountPercent { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }


        /// <summary>
        /// Establishes the one-to-many relationship
        /// </summary>
        public ICollection<Product> ProductList { get; set; }
        /// <summary>
        /// Unique key to communicate between microservices
        /// </summary>
        public string ProductDiscountGuid { get; set; }
    }
}
