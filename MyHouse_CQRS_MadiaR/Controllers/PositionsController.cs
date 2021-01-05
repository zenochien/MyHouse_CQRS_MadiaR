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
    [Route("Positions")]
    [ApiController]
    public class PositionsController : Controller
    {
        private readonly IMediator _mediator;

        public PositionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Positions>> Index()
        {
            return _mediator.Send(new GetAllPositionsQuery());
        }


        [HttpPost]
        public async Task<Response<Positions>> Index([FromBody] CreatePositionsCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
