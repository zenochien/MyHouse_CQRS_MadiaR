using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
   public class UpdatePaymentTypesCommand : IRequestWrapper<PaymentTypes>
    {
        public PaymentTypes Entity { get; set; }
    }

    public class UpdatePaymentTypesCommandHandler : IHandlerWrapper<UpdatePaymentTypesCommand, PaymentTypes>
    {
        private readonly IRespositony<PaymentTypes> _respositony;

        public UpdatePaymentTypesCommandHandler(IRespositony<PaymentTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<PaymentTypes>> Handle(UpdatePaymentTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
