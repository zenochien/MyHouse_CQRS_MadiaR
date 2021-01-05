using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteRoomsCommand : IRequestWrapper<Rooms>
    {
        public Rooms Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteRoomsCommandHandler : IHandlerWrapper<DeleteRoomsCommand, Rooms>
    {
        private readonly IRespositony<Rooms> _respositony;

        public DeleteRoomsCommandHandler(IRespositony<Rooms> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Rooms>> Handle(DeleteRoomsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
