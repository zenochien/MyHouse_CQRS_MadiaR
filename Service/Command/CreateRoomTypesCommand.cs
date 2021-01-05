using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomTypesCommand : IRequestWrapper<RoomTypes>
    {
    }

    public class CreateRoomTypesCommandHandler : IHandlerWrapper<CreateRoomTypesCommand, RoomTypes>
    {
        public async Task<Response<RoomTypes>> Handle(CreateRoomTypesCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<RoomTypes>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new RoomTypes { }, "Đã thành công"));
        }
    }
}
