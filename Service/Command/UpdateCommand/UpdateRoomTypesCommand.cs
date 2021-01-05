using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateRoomTypesCommand : IRequestWrapper<RoomTypes>
    {
        public RoomTypes Entity { get; set; }
    }

    public class UpdateRoomTypesCommandHandler : IHandlerWrapper<UpdateRoomTypesCommand, RoomTypes>
    {
        private readonly IRespositony<RoomTypes> _respositony;

        public UpdateRoomTypesCommandHandler(IRespositony<RoomTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomTypes>> Handle(UpdateRoomTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
