using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Command.DeleteCommand;
using Service.Command.UpdateCommand;
using Service.Data;
using Service.Queries;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("Payments")]
    [ApiController]
    public class PaymentsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public PaymentsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Payments>> Index()
        {
            return await _mediator.Send(new GetAllPaymentsQuery());
        }

        [HttpPost]
        public async Task<Response<Payments>> Index([FromBody] CreatePaymentsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePaymentsCommand command)
        {
            if (command == null || command.Entity.PaymentID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePaymentsCommand { Id = id });

            return NoContent();
        }
    }
}
