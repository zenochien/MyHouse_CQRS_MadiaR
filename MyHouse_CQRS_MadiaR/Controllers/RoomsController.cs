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
    [Route("Rooms")]
    [ApiController]
    public class RoomsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RoomsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Rooms>> Index()
        {
            return await _mediator.Send(new GetAllRoomsQuery());
        }

        [HttpPost]
        public async Task<Response<Rooms>> Index([FromBody] CreateRoomsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRoomsCommand command)
        {
            if (command == null || command.Entity.RoomsID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRoomsCommand { Id = id });

            return NoContent();
        }
    }
}
