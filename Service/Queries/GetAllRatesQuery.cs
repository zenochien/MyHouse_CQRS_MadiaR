using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllRatesQuery : BaseRequest, IRequest<IEnumerable<Rates>>
    {
    }

    public class GetAllRatesQueryHandler : IRequestHandler<GetAllRatesQuery, IEnumerable<Rates>>
    {
        public GetAllRatesQueryHandler()
        {
        }

        public async Task<IEnumerable<Rates>> Handle(GetAllRatesQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Rates
                {

                }
            };
        }
    }
}
