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
    [Route("Rates")]
    [ApiController]
    public class RatesStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RatesStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Rates>> Index()
        {
            return await _mediator.Send(new GetAllRatesQuery());
        }

        [HttpPost]
        public async Task<Response<Rates>> Index([FromBody] CreateRatesCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRatesCommand command)
        {
            if (command == null || command.Entity.RateID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRatesCommand { Id = id });

            return NoContent();
        }
    }
}
