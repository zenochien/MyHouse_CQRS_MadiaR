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
    [Route("PaymentStatus")]
    [ApiController]
    public class PaymentStatusController : Controller
    {
        private readonly IMediator _mediator;

        public PaymentStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<PaymentStatus>> Index()
        {
            return _mediator.Send(new GetAllPaymentStatusQuery());
        }

        [HttpPost]
        public async Task<Response<PaymentStatus>> Index([FromBody] CreatePaymentStatusCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
