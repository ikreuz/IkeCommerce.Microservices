using IkeCommerce.Microservices.Api.Product.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(NewProduct.ExecuteApplication data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product.Model.Product>>> GetProduct()
        {
            return await _mediator.Send(new QueryProduct.ExecuteApplication());
        }
    }
}
