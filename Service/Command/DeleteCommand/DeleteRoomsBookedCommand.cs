using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteRoomsBookedCommand : IRequestWrapper<RoomsBooked>
    {
        public RoomsBooked Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteRoomsBookedCommandHandler : IHandlerWrapper<DeleteRoomsBookedCommand, RoomsBooked>
    {
        private readonly IRespositony<RoomsBooked> _respositony;

        public DeleteRoomsBookedCommandHandler(IRespositony<RoomsBooked> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomsBooked>> Handle(DeleteRoomsBookedCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
