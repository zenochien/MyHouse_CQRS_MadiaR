using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePaymentTypesCommand : IRequestWrapper<PaymentTypes>
    {
    }

    public class CreatePaymentTypesCommandHandler : IHandlerWrapper<CreatePaymentTypesCommand, PaymentTypes>
    {
        public async Task<Response<PaymentTypes>> Handle(CreatePaymentTypesCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<PaymentTypes>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new PaymentTypes { }, "Đã thành công"));
        }
    }
}
