using MediatR;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Query
{
    public class GetAllHotelsQuery : IRequest<IEnumerable<Hotels>>
    {
    }

    public class GetAllHotelsQueryHandler : IRequestHandler<GetAllHotelsQuery, IEnumerable<Hotels>>
    {
        public async Task<IEnumerable<Hotels>> Handle(GetAllHotelsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Hotels()
                {
                    HotelID = Guid.NewGuid(),
                    HotelCode = "1234",
                    Name = "Spa Biển Đep5",
                    Motto = "SSS",
                    Address = "43 Nguyễn Thị Sáu",
                    Address2 = "",
                    City = "Hồ Chí Minh",
                    State = "?",
                    ZipCOde = "007",
                    MainPhoneNumber = "123456789",
                    FaxNumber = "0123456789",
                    TooIIFreeNumber = "0123456789",
                    CompanyeMailAddress = "nguyenvananh@mail.com",
                    WebsiteAddress = "Vietnam",
                    Main = "AAAA",
                    ImagePath = "AAAAA",
                }
            };
        }
    }
}
