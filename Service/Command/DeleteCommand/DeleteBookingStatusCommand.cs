using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteBookingStatusCommand : IRequestWrapper<BookingStatus>
    {
        public BookingStatus Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteBookingStatusCommandHandler : IHandlerWrapper<DeleteBookingStatusCommand, BookingStatus>
    {
        private readonly IRespositony<BookingStatus> _respositony;

        public DeleteBookingStatusCommandHandler(IRespositony<BookingStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<BookingStatus>> Handle(DeleteBookingStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
