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
                    BookingID = new int(),
                    HotelID = new int(),
                    GuestID = new int(),
                    ReservationAgentID = new int(),
                    DateFrom = new DateTime(2020, 12, 02),
                    DateTo = new DateTime(2020, 11, 02),
                    RoomCount = "03",
                    BookingStatusID = new int(),
                }
            };

        }
    }
}