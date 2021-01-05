using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteRoomStatusCommand : IRequestWrapper<RoomStatus>
    {
        public RoomStatus Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteRoomStatusCommandHandler : IHandlerWrapper<DeleteRoomStatusCommand, RoomStatus>
    {
        private readonly IRespositony<RoomStatus> _respositony;

        public DeleteRoomStatusCommandHandler(IRespositony<RoomStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomStatus>> Handle(DeleteRoomStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
