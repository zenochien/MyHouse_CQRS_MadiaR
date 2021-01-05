using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllPositionsQuery : BaseRequest, IRequest<IEnumerable<Positions>>
    {
    }

    public class GetAllPositionsQueryHandler : IRequestHandler<GetAllPositionsQuery, IEnumerable<Positions>>
    {
        public GetAllPositionsQueryHandler()
        {
        }

        public async Task<IEnumerable<Positions>> Handle(GetAllPositionsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Positions
                {

                }
            };
        }
    }
}
