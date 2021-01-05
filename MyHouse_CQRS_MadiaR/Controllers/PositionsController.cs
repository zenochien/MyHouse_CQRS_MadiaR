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
    [Route("Positions")]
    [ApiController]
    public class PositionsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public PositionsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Positions>> Index()
        {
            return await _mediator.Send(new GetAllPositionsQuery());
        }

        [HttpPost]
        public async Task<Response<Positions>> Index([FromBody] CreatePositionsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePositionsCommand command)
        {
            if (command == null || command.Entity.PositionID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePositionsCommand { Id = id });

            return NoContent();
        }
    }
}
