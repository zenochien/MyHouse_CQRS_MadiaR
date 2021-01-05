using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdatePaymentStatusCommand : IRequestWrapper<PaymentStatus>
    {
        public PaymentStatus Entity { get; set; }
    }

    public class UpdatePaymentStatusCommandHandler : IHandlerWrapper<UpdatePaymentStatusCommand, PaymentStatus>
    {
        private readonly IRespositony<PaymentStatus> _respositony;

        public UpdatePaymentStatusCommandHandler(IRespositony<PaymentStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<PaymentStatus>> Handle(UpdatePaymentStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
