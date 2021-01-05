using Service.Respone;
using Service.Wrappers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateBookingStatusCommand : IRequestWrapper<BookingStatus>
    {
    }

    public class CreateBookingStatusCommandHandler : IHandlerWrapper<CreateBookingStatusCommand, BookingStatus>
    {
        public async Task<Response<BookingStatus>> Handle(CreateBookingStatusCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<BookingStatus>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new BookingStatus { BookingStatusID = new Guid(), Active = "sss", Status = "eeww" }, "đã thành công"));
        }
    }
}
