using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Data;
using Service.Query;
using Service.Respone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("hotels")]
    [ApiController]
    public class HotelsController : Controller
    {
        private readonly IMediator _mediator;

        public HotelsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Hotels>> Index()
        {
            return _mediator.Send(new GetAllHotelsQuery());
        }


        [HttpPost]
        public async Task<Response<Hotels>> Index([FromBody] CreateHotelCommand command)
        {
            return await _mediator.Send(command);
        }

    }
}
