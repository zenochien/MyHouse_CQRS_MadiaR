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
    [Route("RoomTypes")]
    [ApiController]
    public class RoomTypesController : Controller
    {
        private readonly IMediator _mediator;

        public RoomTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<RoomTypes>> Index()
        {
            return _mediator.Send(new GetAllRoomTypesQuery());
        }


        [HttpPost]
        public async Task<Response<RoomTypes>> Index([FromBody] CreateRoomTypesCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
