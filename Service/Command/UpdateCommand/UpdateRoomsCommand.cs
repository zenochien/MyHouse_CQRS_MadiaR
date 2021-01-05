using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateRoomsCommand : IRequestWrapper<Rooms>
    {
        public Rooms Entity { get; set; }
    }

    public class UpdateRoomsCommandHandler : IHandlerWrapper<UpdateRoomsCommand, Rooms>
    {
        private readonly IRespositony<Rooms> _respositony;

        public UpdateRoomsCommandHandler(IRespositony<Rooms> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Rooms>> Handle(UpdateRoomsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
