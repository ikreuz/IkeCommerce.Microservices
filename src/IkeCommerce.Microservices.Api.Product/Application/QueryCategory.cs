using IkeCommerce.Microservices.Api.Product.Model;
using IkeCommerce.Microservices.Api.Product.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Application
{
    public class QueryCategory
    {
        public class ExecuteApplication : IRequest<List<Product.Model.ProductCategory>>
        {
        }

        public class HandlerApplication : IRequestHandler<ExecuteApplication, List<Product.Model.ProductCategory>>
        {
            public readonly ProductContext _context;

            public HandlerApplication(ProductContext context)
            {
                _context = context;
            }

            public async Task<List<ProductCategory>> Handle(ExecuteApplication request, CancellationToken cancellationToken)
            {
                var productCategory = await _context.ProductCategory.ToListAsync();

                return productCategory;
            }
        }
    }
}
