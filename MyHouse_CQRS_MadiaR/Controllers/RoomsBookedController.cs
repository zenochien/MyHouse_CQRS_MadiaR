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
    [Route("RoomsBooked")]
    [ApiController]
    public class RoomsBookedStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RoomsBookedStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RoomsBooked>> Index()
        {
            return await _mediator.Send(new GetAllRoomBookedQuery());
        }

        [HttpPost]
        public async Task<Response<RoomsBooked>> Index([FromBody] CreateRoomsBookedCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRoomsBookedCommand command)
        {
            if (command == null || command.Entity.RoomBookedID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRoomsBookedCommand { Id = id });

            return NoContent();
        }
    }
}
