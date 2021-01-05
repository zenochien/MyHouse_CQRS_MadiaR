using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteStaffRoomsCommand : IRequestWrapper<StaffRooms>
    {
        public StaffRooms Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteStaffRoomsCommandHandler : IHandlerWrapper<DeleteStaffRoomsCommand, StaffRooms>
    {
        private readonly IRespositony<StaffRooms> _respositony;

        public DeleteStaffRoomsCommandHandler(IRespositony<StaffRooms> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<StaffRooms>> Handle(DeleteStaffRoomsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
