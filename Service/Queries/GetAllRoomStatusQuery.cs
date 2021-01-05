using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllRoomStatusQuery : BaseRequest, IRequest<IEnumerable<RoomStatus>>
    {
    }

    public class GetAllRoomStatusQueryHandler : IRequestHandler<GetAllRoomStatusQuery, IEnumerable<RoomStatus>>
    {
        public GetAllRoomStatusQueryHandler()
        {
        }

        public async Task<IEnumerable<RoomStatus>> Handle(GetAllRoomStatusQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new RoomStatus
                {

                }
            };
        }
    }
}
