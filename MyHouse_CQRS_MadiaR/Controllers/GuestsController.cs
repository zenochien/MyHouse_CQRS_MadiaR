using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Commad;
using Service.Data;
using Service.Query;
using Service.Respone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("guests")]
    [ApiController]
    public class GuestsController : Controller
    {
        private readonly IMediator _mediator;

        public GuestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Guests>> Index()
        {
            return _mediator.Send(new GetAllGuestQuery());
        }

        [HttpPost]
        public async Task<Response<Guests>> Index([FromBody] CreateGuestsCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
