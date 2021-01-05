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
    [Route("roomsbooked")]
    [ApiController]
    public class RoomsBookedController : Controller
    {
        private readonly IMediator _mediator;

        public RoomsBookedController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<RoomsBooked>> index()
        {
            return _mediator.Send(new GetAllRoomBookedQuery());
        }


        [HttpPost]
        public async Task<Response<RoomsBooked>> Index([FromBody] CreateRoomsBookedCommand command)
        {
            return await _mediator.Send(command);
        }

    }
}
