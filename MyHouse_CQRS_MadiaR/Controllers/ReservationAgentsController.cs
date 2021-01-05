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
    [Route("reservationagents")]
    [ApiController]
    public class ReservationAgentsController : Controller
    {
        private readonly IMediator _mediator;

        public ReservationAgentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<ReservationAgents>> Index()
        {
            return _mediator.Send(new GetAllReservationAgentsQuery());
        }


        [HttpPost]
        public async Task<Response<ReservationAgents>> Index([FromBody] CreateReservationAgentsCommand command)
        {
            return await _mediator.Send(command);
        }

    }
}
