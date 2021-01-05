using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Commad;
using Service.Command;
using Service.Data;
using Service.Query;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [ApiController]
    [Route("booking")]
    public class BookingsController : Controller
    {
        private readonly IMediator _mediator;

        public BookingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> Index()
        {
            return await _mediator.Send(new GetAllBookingQuery());
        }

        [HttpPost]
        public async Task<Response<Booking>> Index([FromBody] CreateBookingCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}