using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateBookingStatusCommand : IRequestWrapper<BookingStatus>
    {
        public BookingStatus Entity { get; set; }
    }

    public class UpdateBookingStatusCommandHandler : IHandlerWrapper<UpdateBookingStatusCommand, BookingStatus>
    {
        private readonly IRespositony<BookingStatus> _respositony;

        public UpdateBookingStatusCommandHandler(IRespositony<BookingStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<BookingStatus>> Handle(UpdateBookingStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
