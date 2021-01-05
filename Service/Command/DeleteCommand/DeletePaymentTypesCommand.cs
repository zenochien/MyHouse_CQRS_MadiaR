using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeletePaymentTypesCommand : IRequestWrapper<PaymentTypes>
    {
        public PaymentTypes Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeletePaymentTypesCommandHandler : IHandlerWrapper<DeletePaymentTypesCommand, PaymentTypes>
    {
        private readonly IRespositony<PaymentTypes> _respositony;

        public DeletePaymentTypesCommandHandler(IRespositony<PaymentTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<PaymentTypes>> Handle(DeletePaymentTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
