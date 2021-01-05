using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command.DeleteCommand;
using Service.Command.UpdateCommand;
using Service.Data;
using Service.Query;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("ReservationAgents")]
    [ApiController]
    public class ReservationAgentsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public ReservationAgentsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<ReservationAgents>> Index()
        {
            return await _mediator.Send(new GetAllReservationAgentsQuery());
        }

        [HttpPost]
        public async Task<Response<ReservationAgents>> Index([FromBody] CreateReservationAgentsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateReservationAgentsCommand command)
        {
            if (command == null || command.Entity.ReservationAgentID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteReservationAgentsCommand { Id = id });

            return NoContent();
        }
    }
}

