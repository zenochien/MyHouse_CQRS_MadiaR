using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateStaffRoomsCommand : IRequestWrapper<StaffRooms>
    {
    }

    public class CreateStaffRoomsCommandHandler : IHandlerWrapper<CreateStaffRoomsCommand, StaffRooms>
    {
        public async Task<Response<StaffRooms>> Handle(CreateStaffRoomsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<StaffRooms>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new StaffRooms {  }, "Đã thành công"));
        }
    }
}
