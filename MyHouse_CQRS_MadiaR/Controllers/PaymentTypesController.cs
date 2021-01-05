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
    [Route("PaymentTypes")]
    [ApiController]
    public class PaymentTypesController : Controller
    {
        private readonly IMediator _mediator;

        public PaymentTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<PaymentTypes>> Index()
        {
            return _mediator.Send(new GetAllPaymentTypesQuery());
        }

        [HttpPost]
        public async Task<Response<PaymentTypes>> Index([FromBody] CreatePaymentTypesCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
