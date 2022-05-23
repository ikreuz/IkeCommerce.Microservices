using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class NewInventory
    {
        public class ExecuteApplication : IRequest
        {
            public int Quantity { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? ModifiedAt { get; set; }
            public DateTime? DeletedAt { get; set; }
        }

        public class HandlerApplication : IRequestHandler<ExecuteApplication>
        {
            private readonly ProductContext _context;

            public HandlerApplication(ProductContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(ExecuteApplication request, CancellationToken cancellationToken)
            {
                var inventory = new Product.Model.ProductInventory
                {
                    Quantity = request.Quantity,
                    CreatedAt = request.CreatedAt,
                    ModifiedAt = request.ModifiedAt,
                    DeletedAt = request.DeletedAt,
                    ProductInventoryGuid = Convert.ToString(Guid.NewGuid()),
                };

                _context.ProductInventory.Add(inventory);

                var affected = await _context.SaveChangesAsync();

                if (affected > 0) return Unit.Value;

                throw new Exception("No se pudo insertar el inventario");
            }
        }
    }
}
