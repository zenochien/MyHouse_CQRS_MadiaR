using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllStaffQuery : BaseRequest, IRequest<IEnumerable<Staff>>
    {
    }

    public class GetAllStaffQueryHandler : IRequestHandler<GetAllStaffQuery, IEnumerable<Staff>>
    {
        public GetAllStaffQueryHandler()
        {
        }

        public async Task<IEnumerable<Staff>> Handle(GetAllStaffQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Staff
                {

                }
            };
        }
    }
}
