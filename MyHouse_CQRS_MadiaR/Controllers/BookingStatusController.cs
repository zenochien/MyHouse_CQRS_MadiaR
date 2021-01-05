using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Data;
using Service.Query;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("bookingstatus")]
    [ApiController]
    public class BookingStatusController : Controller
    {
        private readonly IMediator _mediator;

        public BookingStatusController(IMediator mediator)
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
    }
}
