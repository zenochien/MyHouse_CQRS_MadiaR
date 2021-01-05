using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePaymentStatusCommand : IRequestWrapper<PaymentStatus>
    {
        public PaymentStatus Entity { get; set; }
    }

    public class CreatePaymentStatusCommandHandler : IHandlerWrapper<CreatePaymentStatusCommand, PaymentStatus>
    {
        private readonly IRespositony<PaymentStatus> _respositony;

        public CreatePaymentStatusCommandHandler(IRespositony<PaymentStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<PaymentStatus>> Handle(CreatePaymentStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
