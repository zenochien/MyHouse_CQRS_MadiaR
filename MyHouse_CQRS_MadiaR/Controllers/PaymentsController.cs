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
    [Route("Payments")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private readonly IMediator _mediator;

        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Payments>> Index()
        {
            return _mediator.Send(new GetAllPaymentsQuery());
        }


        [HttpPost]
        public async Task<Response<Payments>> Index([FromBody] CreatePaymentsCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
