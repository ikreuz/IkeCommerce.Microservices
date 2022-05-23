using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class NewDiscount
    {
        public class ExecuteApplication : IRequest
        {
            public string Name { get; set; }
            public string Desciption { get; set; }
            public decimal DiscountPercent { get; set; }
            public bool Active { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? ModifiedAt { get; set; }
            public DateTime? DeletedAt { get; set; }
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
                var discount = new Product.Model.ProductDiscount
                {
                    Name = request.Name,
                    Desciption = request.Desciption,
                    DiscountPercent = request.DiscountPercent,
                    Active = request.Active,
                    CreatedAt = request.CreatedAt,
                    ModifiedAt = request.ModifiedAt,
                    DeletedAt = request.DeletedAt,
                    ProductDiscountGuid = Convert.ToString(Guid.NewGuid()),
                };

                _context.ProductDiscount.Add(discount);

                var affected = await _context.SaveChangesAsync();

                if (affected > 0) return Unit.Value;

                throw new Exception("No se pudo inesrtar el descuento");
            }
        }
    }
}
