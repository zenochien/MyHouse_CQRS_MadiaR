using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateRoomsBookedCommand : IRequestWrapper<RoomsBooked>
    {
        public RoomsBooked Entity { get; set; }
    }

    public class CreateRoomsBookedCommandHandler : IHandlerWrapper<CreateRoomsBookedCommand, RoomsBooked>
    {
        private readonly IRespositony<RoomsBooked> _respositony;

        public CreateRoomsBookedCommandHandler(IRespositony<RoomsBooked> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RoomsBooked>> Handle(CreateRoomsBookedCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}

