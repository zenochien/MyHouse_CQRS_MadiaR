using MediatR;
using Service.Data;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Query
{
    public class GetAllBookingQuery : BaseRequest, IRequest<IEnumerable<Booking>>
    {
    }

    public class GetAllBookingQueryHandler : IRequestHandler<GetAllBookingQuery, IEnumerable<Booking>>
    {
        public GetAllBookingQueryHandler()
        {
        }

        public async Task<IEnumerable<Booking>> Handle(GetAllBookingQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Booking
                {
                    BookingID = Guid.NewGuid(),
                    HotelID = Guid.NewGuid(),
                    GuestID = Guid.NewGuid(),
                    ReservationAgentID = Guid.NewGuid(),
                    DateFrom = new DateTime(2020, 12, 02),
                    DateTo = new DateTime(2020, 11, 02),
                    RoomCount = "03",
                    BookingStatusID = Guid.NewGuid()
                }
            };
        }
    }
}