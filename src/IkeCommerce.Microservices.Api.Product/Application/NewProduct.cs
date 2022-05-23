using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class NewProduct
    {
        public class ExecuteApplication : IRequest
        {
            public string Name { get; set; }
            public string Desciption { get; set; }
            public string SKU { get; set; }
            public int CategoryId { get; set; }
            public int InventoryId { get; set; }
            public decimal Price { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? ModifiedAt { get; set; }
            public DateTime? DeletedAt { get; set; }

            public string ProductGuid { get; set; }

            public int ProductDiscountId { get; set; }
            //public Product.Model.ProductDiscount ProductDiscount { get; set; }

            public int ProductCategoryId { get; set; }
            //public Product.Model.ProductCategory ProductCategory { get; set; }

            public int ProductInventoryId { get; set; }
            //public Product.Model.ProductInventory ProductInvetory { get; set; }
        }

        public class HandlerApplication : IRequestHandler<ExecuteApplication>
        {
            public readonly ProductContext _context;

            public HandlerApplication(ProductContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(ExecuteApplication request, CancellationToken cancellationToken)
            {

                var product = new Product.Model.Product
                {
                    Name = request.Name,
                    Desciption = request.Desciption,
                    SKU = request.SKU,
                    CategoryId = request.CategoryId,
                    InventoryId = request.InventoryId,
                    Price = request.Price,
                    CreatedAt = request.CreatedAt,
                    ProductGuid = Convert.ToString(Guid.NewGuid()),
                    ProductDiscountId = request.ProductDiscountId,
                    ProductCategoryId = request.ProductCategoryId,
                    ProductInventoryId = request.ProductInventoryId
                };

                _context.Product.Add(product);

                var affected = await _context.SaveChangesAsync();

                if(affected > 0) return Unit.Value;

                throw new Exception("No se pudo insertar el producto");

            }
        }
    }
}
