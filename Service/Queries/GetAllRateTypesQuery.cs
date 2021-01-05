using MediatR;
using Service.Data;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllRateTypesQuery : BaseRequest, IRequest<IEnumerable<RateTypes>>
    {
    }

    public class GetAllRateTypesQueryHandler : IRequestHandler<GetAllRateTypesQuery, IEnumerable<RateTypes>>
    {
        public GetAllRateTypesQueryHandler()
        {
        }

        public async Task<IEnumerable<RateTypes>> Handle(GetAllRateTypesQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new RateTypes
                {
                    RateTypeID = Guid.NewGuid(),
                        RateType = "vip",
                        Description = "sss",
                        SortOrder = "123",
                        Active = "có"
                }
            };
        }
    }
}
