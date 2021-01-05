using MediatR;
using Service.Data;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Query
{
    public class GetAllGuestQuery : BaseRequest ,IRequest<IEnumerable<Guests>>
    {
    }

    public class GetAllGuestQueryHanler : IRequestHandler<GetAllGuestQuery, IEnumerable<Guests>>
    {
        public GetAllGuestQueryHanler()
        {
        }

        public async Task<IEnumerable<Guests>> Handle(GetAllGuestQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                 new Guests()
                {
                    GuestID = Guid.NewGuid(),
                    FirstName = "Mạnh",
                    LastName = "Nguyễn Văn",
                    Address = "21 Thông Nhất",
                    Address2 = "33 Nguyễn Minh Khai",
                    City = "Hồ Chí Minh",
                    State = "?",
                    ZipCOde = "007",
                    Country = "VietNam",
                    HomePhoneNumber = "0123456789",
                    CellularNumber = "0123456789",
                    eMailAddress = "nguyenvanmanh@mail.com",
                    Gender = "Vietnam"
                 }
            };
        }
    }
}
