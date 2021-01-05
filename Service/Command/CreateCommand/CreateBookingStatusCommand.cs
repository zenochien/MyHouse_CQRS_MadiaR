using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateBookingStatusCommand : IRequestWrapper<BookingStatus>
    {
        public BookingStatus Entity { get; set; }
    }

    public class CreateBookingStatusCommandHandler : IHandlerWrapper<CreateBookingStatusCommand, BookingStatus>
    {
        private readonly IRespositony<BookingStatus> _respositony;

        public CreateBookingStatusCommandHandler(IRespositony<BookingStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<BookingStatus>> Handle(CreateBookingStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
