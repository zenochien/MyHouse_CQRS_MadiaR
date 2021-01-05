using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteRoomTypesCommand : IRequestWrapper<RoomTypes>
    {
        public RoomTypes Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteRoomTypesCommandHandler : IHandlerWrapper<DeleteRoomTypesCommand, RoomTypes>
    {
        private readonly IRespositony<RoomTypes> _respositony;

        public DeleteRoomTypesCommandHandler(IRespositony<RoomTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomTypes>> Handle(DeleteRoomTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
