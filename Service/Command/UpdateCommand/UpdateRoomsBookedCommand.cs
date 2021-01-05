using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateRoomsBookedCommand : IRequestWrapper<RoomsBooked>
    {
        public RoomsBooked Entity { get; set; }
    }

    public class UpdateRoomsBookedCommandHandler : IHandlerWrapper<UpdateRoomsBookedCommand, RoomsBooked>
    {
        private readonly IRespositony<RoomsBooked> _respositony;

        public UpdateRoomsBookedCommandHandler(IRespositony<RoomsBooked> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomsBooked>> Handle(UpdateRoomsBookedCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
