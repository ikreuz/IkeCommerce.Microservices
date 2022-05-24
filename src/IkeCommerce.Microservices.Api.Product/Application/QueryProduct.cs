using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class QueryProduct
    {
        public class ExecuteApplication : IRequest<List<Product.Model.Product>> { }

        public class HandlerApplication : IRequestHandler<ExecuteApplication, List<Product.Model.Product>>
        {
            public readonly ProductContext _context;

            public HandlerApplication(ProductContext context)
            {
                _context = context;
            }

            public async Task<List<Model.Product>> Handle(ExecuteApplication request, CancellationToken cancellationToken)
            {
                var product = await _context.Product.ToListAsync();

                return product;
            }
        }
    }
}
