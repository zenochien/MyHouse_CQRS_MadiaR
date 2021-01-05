using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateStaffRoomsCommand : IRequestWrapper<StaffRooms>
    {
        public StaffRooms Entity { get; set; }
    }

    public class CreateStaffRoomsCommandHandler : IHandlerWrapper<CreateStaffRoomsCommand, StaffRooms>
    {
        private readonly IRespositony<StaffRooms> _respositony;

        public CreateStaffRoomsCommandHandler(IRespositony<StaffRooms> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<StaffRooms>> Handle(CreateStaffRoomsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
