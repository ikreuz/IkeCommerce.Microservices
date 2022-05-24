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
    public class InventoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InventoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(NewInventory.ExecuteApplication data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product.Model.ProductInventory>>> GetProductInventory()
        {
            return await _mediator.Send(new QueryInventory.ExecuteApplication());
        }
    }
}
