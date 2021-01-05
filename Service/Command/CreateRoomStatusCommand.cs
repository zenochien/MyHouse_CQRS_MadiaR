using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomStatusCommand : IRequestWrapper<RoomStatus>
    {
    }

    public class CreateRoomStatusCommandHandler : IHandlerWrapper<CreateRoomStatusCommand, RoomStatus>
    {
        public async Task<Response<RoomStatus>> Handle(CreateRoomStatusCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<RoomStatus>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new RoomStatus { }, "RoomStatus Created"));
        }
    }
}
