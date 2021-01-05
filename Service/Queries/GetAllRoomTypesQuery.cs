using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllRoomTypesQuery : BaseRequest, IRequest<IEnumerable<RoomTypes>>
    {
    }

    public class GetAllRoomTypesQueryHandler : IRequestHandler<GetAllRoomTypesQuery, IEnumerable<RoomTypes>>
    {
        public GetAllRoomTypesQueryHandler()
        {
        }

        public async Task<IEnumerable<RoomTypes>> Handle(GetAllRoomTypesQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new RoomTypes
                {

                }
            };
        }
    }
}