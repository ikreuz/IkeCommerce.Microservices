using System;

namespace IkeCommerce.Microservices.Api.Product.Model
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public string ProductCategoryGuid { get; set; }
    }
}
