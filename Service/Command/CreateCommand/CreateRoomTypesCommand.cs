using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomTypesCommand : IRequestWrapper<RoomTypes>
    {
        public RoomTypes Entity { get; set; }
    }

    public class CreateRoomTypesCommandHandler : IHandlerWrapper<CreateRoomTypesCommand, RoomTypes>
    {
        private readonly IRespositony<RoomTypes> _respositony;

        public CreateRoomTypesCommandHandler(IRespositony<RoomTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomTypes>> Handle(CreateRoomTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
