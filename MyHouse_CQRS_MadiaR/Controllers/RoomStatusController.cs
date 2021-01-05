using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Data;
using Service.Queries;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("RoomStatus")]
    [ApiController]
    public class RoomStatusController : Controller
    {
        private readonly IMediator _mediator;

        public RoomStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<RoomStatus>> Index()
        {
            return _mediator.Send(new GetAllRoomStatusQuery());
        }


        [HttpPost]
        public async Task<Response<RoomStatus>> Index([FromBody] CreateRoomStatusCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
