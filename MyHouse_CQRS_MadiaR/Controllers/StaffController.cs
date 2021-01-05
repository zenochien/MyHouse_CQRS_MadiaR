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
    [Route("Staff")]
    [ApiController]
    public class StaffStatusController : Controller
    {
        private readonly IMediator _mediator;

        public StaffStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Staff>> Index()
        {
            return await _mediator.Send(new GetAllStaffQuery());
        }

        [HttpPost]
        public async Task<Response<Staff>> Index([FromBody] CreateStaffCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateStaffCommand command)
        {
            if (command == null || command.Entity.StaffID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteStaffCommand { Id = id });

            return NoContent();
        }
    }
}
