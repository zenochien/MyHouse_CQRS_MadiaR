using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllStaffRoomsQuery : BaseRequest, IRequest<IEnumerable<StaffRooms>>
    {
    }

    public class GetAllStaffRoomsQueryHandler : IRequestHandler<GetAllStaffRoomsQuery, IEnumerable<StaffRooms>>
    {
        public GetAllStaffRoomsQueryHandler()
        {
        }

        public async Task<IEnumerable<StaffRooms>> Handle(GetAllStaffRoomsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new StaffRooms
                {
                   
                }
            };
        }
    }
}
