using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePaymentTypesCommand : IRequestWrapper<PaymentTypes>
    {
        public PaymentTypes Entity { get; set; }
    }

    public class CreatePaymentTypesCommandHandler : IHandlerWrapper<CreatePaymentTypesCommand, PaymentTypes>
    {
        private readonly IRespositony<PaymentTypes> _respositony;

        public CreatePaymentTypesCommandHandler(IRespositony<PaymentTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<PaymentTypes>> Handle(CreatePaymentTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
