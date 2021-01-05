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
    [Route("RateTypes")]
    [ApiController]
    public class RateTypesStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RateTypesStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RateTypes>> Index()
        {
            return await _mediator.Send(new GetAllRateTypesQuery());
        }

        [HttpPost]
        public async Task<Response<RateTypes>> Index([FromBody] CreateRateTypesCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateRateTypesCommand command)
        {
            if (command == null || command.Entity.RateTypeID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteRateTypesCommand { Id = id });

            return NoContent();
        }
    }
}
