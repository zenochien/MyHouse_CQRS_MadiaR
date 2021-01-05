using MediatR;
using Service.Data;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Queries
{
    public class GetAllPaymentStatusQuery : BaseRequest, IRequest<IEnumerable<PaymentStatus>>
    {
    }

    public class GetAllPaymentStatusQueryHandler : IRequestHandler<GetAllPaymentStatusQuery, IEnumerable<PaymentStatus>>
    {
        public GetAllPaymentStatusQueryHandler()
        {
        }

        public async Task<IEnumerable<PaymentStatus>> Handle(GetAllPaymentStatusQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new PaymentStatus
                {
                    PaymentStatusID = new int(),
                        Status = "123",
                        Description = "12334",
                        SortOrder = "2312",
                        Active = "123123"
                }
            };
        }
    }
}
