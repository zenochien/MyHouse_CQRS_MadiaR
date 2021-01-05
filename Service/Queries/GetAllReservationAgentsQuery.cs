using MediatR;
using Service.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Query
{
    public class GetAllReservationAgentsQuery :IRequest<IEnumerable<ReservationAgents>>
    {
    }

    public class GetAllReservationAgentsQueryHandler : IRequestHandler<GetAllReservationAgentsQuery, IEnumerable<ReservationAgents>>
    {
        public async Task<IEnumerable<ReservationAgents>> Handle(GetAllReservationAgentsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new ReservationAgents()
                {
                    ReservationAgentID = Guid.NewGuid(),
                    FirstName = "Thìa",
                    LastName = "Hương Văn",
                    Address = "21 Thông Mông",
                    Address2 = "33 Nguyễn Minh Mạnh",
                    City = "Hồ Chí Minh",
                    State = "?",
                    ZipCOde = "443",
                    Country = "VietNam",
                    HomePhoneNumber = "0123456789",
                    CellularNumber = "0123456789",
                    eMailAddress = "huongvanthia@mail.com",
                    Gender = "Vietnam"
                }
            };
        }
    }
}
