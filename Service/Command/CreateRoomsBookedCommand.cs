using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomsBookedCommand : IRequestWrapper<RoomsBooked>
    {
    }

    public class CreateRoomsBookedCommandHandler : IHandlerWrapper<CreateRoomsBookedCommand, RoomsBooked>
    {
        public async Task<Response<RoomsBooked>> Handle(CreateRoomsBookedCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<RoomsBooked>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new RoomsBooked { RoomBookedID = new Guid() }, "sssss"));
        }
    }
}

