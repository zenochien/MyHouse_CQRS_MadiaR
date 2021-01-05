using MediatR;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Query
{
    public class GetAllBookingStatusQuery : IRequest<IEnumerable<BookingStatus>>
    {
    }

    public class GetAllBookingStatusHanler : IRequestHandler<GetAllBookingStatusQuery, IEnumerable<BookingStatus>>
    {
        public GetAllBookingStatusHanler()
        {
                
        }

        public async Task<IEnumerable<BookingStatus>> Handle(GetAllBookingStatusQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new BookingStatus
                    {
                        BookingStatusID = new int(),
                        Status = "Tốt",
                        Description = "Đẹp và sạch sẽ",
                        SortOrder = "1",
                        Active = "Có",
                    }
            };
        }
    }
}
