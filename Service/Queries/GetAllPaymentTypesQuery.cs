using MediatR;
using Service.Data;
using Service.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllPaymentTypesQuery : BaseRequest, IRequest<IEnumerable<PaymentTypes>>
    {
    }

    public class GetAllPaymentTypesQueryHandler : IRequestHandler<GetAllPaymentTypesQuery, IEnumerable<PaymentTypes>>
    {
        public GetAllPaymentTypesQueryHandler()
        {
        }

        public async Task<IEnumerable<PaymentTypes>> Handle(GetAllPaymentTypesQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new PaymentTypes
                {

                }
            };
        }
    }
}
