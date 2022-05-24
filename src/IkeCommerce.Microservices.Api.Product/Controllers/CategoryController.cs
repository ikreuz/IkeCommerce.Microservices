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
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(NewCategory.ExecuteApplication data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product.Model.ProductCategory>>> GetProductCategory()
        {
            return await _mediator.Send(new QueryCategory.ExecuteApplication());
        }

    }
}
