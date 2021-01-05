using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomsCommand : IRequestWrapper<Rooms>
    {
        public Rooms Entity { get; set; }
    }

    public class CreateRoomsCommandHandler : IHandlerWrapper<CreateRoomsCommand, Rooms>
    {
        private readonly IRespositony<Rooms> _respositony;

        public CreateRoomsCommandHandler(IRespositony<Rooms> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Rooms>> Handle(CreateRoomsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
