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
    [Route("PaymentTypes")]
    [ApiController]
    public class PaymentTypesStatusController : Controller
    {
        private readonly IMediator _mediator;

        public PaymentTypesStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<PaymentTypes>> Index()
        {
            return await _mediator.Send(new GetAllPaymentTypesQuery());
        }

        [HttpPost]
        public async Task<Response<PaymentTypes>> Index([FromBody] CreatePaymentTypesCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePaymentTypesCommand command)
        {
            if (command == null || command.Entity.PaymentTypeID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePaymentTypesCommand { Id = id });

            return NoContent();
        }
    }
}
