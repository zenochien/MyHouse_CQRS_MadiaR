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
    [Route("Hotels")]
    [ApiController]
    public class HotelsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public HotelsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Hotels>> Index()
        {
            return await _mediator.Send(new GetAllHotelsQuery());
        }

        [HttpPost]
        public async Task<Response<Hotels>> Index([FromBody] CreateHotelsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateHotelsCommand command)
        {
            if (command == null || command.Entity.HotelID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteHotelsCommand { Id = id });

            return NoContent();
        }
    }
}

