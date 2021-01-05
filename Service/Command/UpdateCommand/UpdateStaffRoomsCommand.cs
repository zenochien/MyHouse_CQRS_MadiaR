using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateStaffRoomsCommand : IRequestWrapper<StaffRooms>
    {
        public StaffRooms Entity { get; set; }
    }

    public class UpdateStaffRoomsCommandHandler : IHandlerWrapper<UpdateStaffRoomsCommand, StaffRooms>
    {
        private readonly IRespositony<StaffRooms> _respositony;

        public UpdateStaffRoomsCommandHandler(IRespositony<StaffRooms> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<StaffRooms>> Handle(UpdateStaffRoomsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
