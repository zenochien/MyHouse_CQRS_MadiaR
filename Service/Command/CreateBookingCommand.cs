using Service.Respone;
using Service.Wrappers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateBookingCommand : IRequestWrapper<Booking>
    {
    }

    public class CreateBookingCommandHandler : IHandlerWrapper<CreateBookingCommand, Booking>
    {
        public async Task<Response<Booking>> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Booking>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new Booking { BookingID = new Guid(), RoomCount = "444" }, "Đã thành công"));
        }
    }
}
