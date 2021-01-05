using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllRoomsQuery : BaseRequest, IRequest<IEnumerable<Rooms>>
    {
    }

    public class GetAllRoomsQueryHandler : IRequestHandler<GetAllRoomsQuery, IEnumerable<Rooms>>
    {
        public GetAllRoomsQueryHandler()
        {
        }

        public async Task<IEnumerable<Rooms>> Handle(GetAllRoomsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Rooms
                {

                }
            };
        }
    }
}
