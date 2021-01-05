using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateRoomStatusCommand : IRequestWrapper<RoomStatus>
    {
        public RoomStatus Entity { get; set; }
    }

    public class UpdateRoomStatusCommandHandler : IHandlerWrapper<UpdateRoomStatusCommand, RoomStatus>
    {
        private readonly IRespositony<RoomStatus> _respositony;

        public UpdateRoomStatusCommandHandler(IRespositony<RoomStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomStatus>> Handle(UpdateRoomStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
