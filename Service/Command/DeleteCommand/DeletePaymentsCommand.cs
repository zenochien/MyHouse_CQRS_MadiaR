using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeletePaymentsCommand : IRequestWrapper<Payments>
    {
        public Payments Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeletePaymentsCommandHandler : IHandlerWrapper<DeletePaymentsCommand, Payments>
    {
        private readonly IRespositony<Payments> _respositony;

        public DeletePaymentsCommandHandler(IRespositony<Payments> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Payments>> Handle(DeletePaymentsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
