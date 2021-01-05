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
    [ApiController]
    [Route("RateTypes")]
    public class RateTypesController : Controller
    {
        private readonly IMediator _mediator;

        public RateTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RateTypes>> Index()
        {
            return await _mediator.Send(new GetAllRateTypesQuery());
        }

        [HttpPost]
        public async Task<Response<RateTypes>> Index([FromBody] CreateRateTypesCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
