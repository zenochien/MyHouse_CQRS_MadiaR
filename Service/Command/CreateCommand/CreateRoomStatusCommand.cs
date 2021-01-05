using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomStatusCommand : IRequestWrapper<RoomStatus>
    {
        public RoomStatus Entity { get; set; }
    }

    public class CreateRoomStatusCommandHandler : IHandlerWrapper<CreateRoomStatusCommand, RoomStatus>
    {
        private readonly IRespositony<RoomStatus> _respositony;

        public CreateRoomStatusCommandHandler(IRespositony<RoomStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomStatus>> Handle(CreateRoomStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
