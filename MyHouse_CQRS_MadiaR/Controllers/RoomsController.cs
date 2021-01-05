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
    [Route("Rooms")]
    [ApiController]
    public class RoomsController : Controller
    {
        private readonly IMediator _mediator;

        public RoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Rooms>> Index()
        {
            return _mediator.Send(new GetAllRoomsQuery());
        }


        [HttpPost]
        public async Task<Response<Rooms>> Index([FromBody] CreateRoomsCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
