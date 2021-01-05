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
    [Route("BookingStatus")]
    [ApiController]
    public class BookingStatusStatusController : Controller
    {
        private readonly IMediator _mediator;

        public BookingStatusStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<BookingStatus>> Index()
        {
            return await _mediator.Send(new GetAllBookingStatusQuery());
        }

        [HttpPost]
        public async Task<Response<BookingStatus>> Index([FromBody] CreateBookingStatusCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateBookingStatusCommand command)
        {
            if (command == null || command.Entity.BookingStatusID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteBookingStatusCommand { Id = id });

            return NoContent();
        }
    }
}
