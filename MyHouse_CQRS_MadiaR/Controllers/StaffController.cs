using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Data;
using Service.Queries;
using Service.Query;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("Staff")]
    [ApiController]
    public class StaffController : Controller
    {
        private readonly IMediator _mediator;

        public StaffController(IMediator mediator)
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
    }
}
