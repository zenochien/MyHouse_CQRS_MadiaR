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
    [Route("PaymentStatus")]
    [ApiController]
    public class PaymentStatusStatusController : Controller
    {
        private readonly IMediator _mediator;

        public PaymentStatusStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<PaymentStatus>> Index()
        {
            return await _mediator.Send(new GetAllPaymentStatusQuery());
        }

        [HttpPost]
        public async Task<Response<PaymentStatus>> Index([FromBody] CreatePaymentStatusCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePaymentStatusCommand command)
        {
            if (command == null || command.Entity.PaymentStatusID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePaymentStatusCommand { Id = id });

            return NoContent();
        }
    }
}
