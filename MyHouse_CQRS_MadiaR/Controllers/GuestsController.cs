using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Command.DeleteCommand;
using Service.Command.UpdateCommand;
using Service.Data;
using Service.Query;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("Guests")]
    [ApiController]
    public class GuestsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public GuestsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Guests>> Index()
        {
            return await _mediator.Send(new GetAllGuestQuery());
        }

        [HttpPost]
        public async Task<Response<Guests>> Index([FromBody] CreateGuestsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateGuestsCommand command)
        {
            if (command == null || command.Entity.GuestID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteGuestCommand { Id = id });

            return NoContent();
        }
    }
}
