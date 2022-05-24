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
    public class DiscountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DiscountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(NewDiscount.ExecuteApplication data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product.Model.ProductDiscount>>> GetProductDiscount()
        {
            return await _mediator.Send(new QueryDiscount.ExecuteApplication());
        }
    }
}
