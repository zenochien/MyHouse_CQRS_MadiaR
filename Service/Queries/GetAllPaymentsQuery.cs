using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllPaymentsQuery: BaseRequest, IRequest<IEnumerable<Payments>>
    {
    }

    public class GetAllPaymentsQueryHandler : IRequestHandler<GetAllPaymentsQuery, IEnumerable<Payments>>
    {
        public GetAllPaymentsQueryHandler()
        {
        }

        public async Task<IEnumerable<Payments>> Handle(GetAllPaymentsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Payments
                {
                    
                }
            };
        }
    }
}
