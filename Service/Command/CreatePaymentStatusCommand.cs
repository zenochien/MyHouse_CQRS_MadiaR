using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePaymentStatusCommand : IRequestWrapper<PaymentStatus>
    {
    }

    public class CreatePaymentStatusCommandHandler : IHandlerWrapper<CreatePaymentStatusCommand, PaymentStatus>
    {
        public async Task<Response<PaymentStatus>> Handle(CreatePaymentStatusCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<PaymentStatus>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new PaymentStatus { }, "Đã thành công"));
        }
    }
}
