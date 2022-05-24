using IkeCommerce.Microservices.Api.Product.Model;
using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class QueryInventory
    {
        public class ExecuteApplication : IRequest<List<Product.Model.ProductInventory>> { }

        public class HandlerApplication : IRequestHandler<ExecuteApplication, List<Product.Model.ProductInventory>>
        {
            public readonly ProductContext _context;

            public HandlerApplication(ProductContext context)
            {
                _context = context;
            }

            public async Task<List<ProductInventory>> Handle(ExecuteApplication request, CancellationToken cancellationToken)
            {
                var productInventory = await _context.ProductInventory.ToListAsync();

                return productInventory;
            }
        }
    }
}
