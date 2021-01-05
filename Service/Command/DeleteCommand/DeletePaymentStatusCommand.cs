using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeletePaymentStatusCommand : IRequestWrapper<PaymentStatus>
    {
        public PaymentStatus Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeletePaymentStatusCommandHandler : IHandlerWrapper<DeletePaymentStatusCommand, PaymentStatus>
    {
        private readonly IRespositony<PaymentStatus> _respositony;

        public DeletePaymentStatusCommandHandler(IRespositony<PaymentStatus> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<PaymentStatus>> Handle(DeletePaymentStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
