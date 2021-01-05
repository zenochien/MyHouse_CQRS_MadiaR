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
    [Route("Rates")]
    [ApiController]
    public class RatesController : Controller
    {
        private readonly IMediator _mediator;

        public RatesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Rates>> Index()
        {
            return _mediator.Send(new GetAllRatesQuery());
        }


        [HttpPost]
        public async Task<Response<Rates>> Index([FromBody] CreateRatesCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
