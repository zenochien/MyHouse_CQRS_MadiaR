using MediatR;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Query
{
    public  class GetAllRoomBookedQuery :IRequest<IEnumerable<RoomsBooked>>
    {
    }

    public class GetAllRoomBookedQueryHandler : IRequestHandler<GetAllRoomBookedQuery, IEnumerable<RoomsBooked>>
    {
        public async Task<IEnumerable<RoomsBooked>> Handle(GetAllRoomBookedQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new RoomsBooked()
                {
                    RoomBookedID = Guid.NewGuid(),
                    BookingID = Guid.NewGuid(),
                    Rate = 5
                }
            };
        }
    }
}
