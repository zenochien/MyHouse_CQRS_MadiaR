﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service.Command;
using Service.Command.DeleteCommand;
using Service.Command.UpdateCommand;
using Service.Data;
using Service.Queries;
using Service.Respone;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Controllers
{
    [Route("StaffRooms")]
    [ApiController]
    public class StaffRoomsStatusController : Controller
    {
        private readonly IMediator _mediator;

        public StaffRoomsStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<StaffRooms>> Index()
        {
            return await _mediator.Send(new GetAllStaffRoomsQuery());
        }

        [HttpPost]
        public async Task<Response<StaffRooms>> Index([FromBody] CreateStaffRoomsCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateStaffRoomsCommand command)
        {
            if (command == null || command.Entity.StaffRoomID != id)
            {
                return BadRequest();
            }

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteStaffRoomsCommand { Id = id });

            return NoContent();
        }
    }
}
