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
    [Route("StaffRooms")]
    [ApiController]
    public class StaffRoomsController : Controller
    {
        private readonly IMediator _mediator;

        public StaffRoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<StaffRooms>> Index()
        {
            return _mediator.Send(new GetAllStaffRoomsQuery());
        }


        [HttpPost]
        public async Task<Response<StaffRooms>> Index([FromBody] CreateStaffRoomsCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
