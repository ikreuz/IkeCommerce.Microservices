using IkeCommerce.Microservices.Api.Product.Model;
using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class QueryDiscount
    {
        public class ExecuteApplication : IRequest<List<Product.Model.ProductDiscount>>
        {

        }

        public class HandlerApplication : IRequestHandler<ExecuteApplication, List<Product.Model.ProductDiscount>>
        {
            public readonly ProductContext _context;

            public HandlerApplication(ProductContext context)
            {
                _context = context;
            }

            public async Task<List<ProductDiscount>> Handle(ExecuteApplication request, CancellationToken cancellationToken)
            {
                var productDiscount = await _context.ProductDiscount.ToListAsync();

                return productDiscount;
            }
        }
    }
}
