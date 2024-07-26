using EShop.Orders.Application.Commands;
using EShop.Orders.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Orders.Api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) 
        {
            var query = new GetOrderById(id);

            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddOrder command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(Get), new { id }, command);
        }
    }
}
