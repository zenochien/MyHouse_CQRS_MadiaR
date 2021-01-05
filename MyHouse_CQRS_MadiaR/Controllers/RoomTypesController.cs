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
    [Route("RoomTypes")]
    [ApiController]
    public class RoomTypesStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RoomTypesStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RoomTypes>> Index()
        {
            return await _mediator.Send(new GetAllRoomTypesQuery());
        }

        [HttpPost]
        public async Task<Response<RoomTypes>> Index([FromBody] CreateRoomTypesCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRoomTypesCommand command)
        {
            if (command == null || command.Entity.RoomTypeID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRoomTypesCommand { Id = id });

            return NoContent();
        }
    }
}
