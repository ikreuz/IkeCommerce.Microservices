using System;
using System.Collections.Generic;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
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
        public string ProductCategoryGuid { get; set; }
    }
}
