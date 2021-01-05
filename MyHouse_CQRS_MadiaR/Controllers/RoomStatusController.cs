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
    [Route("RoomStatus")]
    [ApiController]
    public class RoomStatusStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RoomStatusStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RoomStatus>> Index()
        {
            return await _mediator.Send(new GetAllRoomStatusQuery());
        }

        [HttpPost]
        public async Task<Response<RoomStatus>> Index([FromBody] CreateRoomStatusCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRoomStatusCommand command)
        {
            if (command == null || command.Entity.RoomStatusID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRoomStatusCommand { Id = id });

            return NoContent();
        }
    }
}
