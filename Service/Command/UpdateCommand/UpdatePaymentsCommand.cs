using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdatePaymentsCommand : IRequestWrapper<Payments>
    {
        public Payments Entity { get; set; }
    }

    public class UpdatePaymentsCommandHandler : IHandlerWrapper<UpdatePaymentsCommand, Payments>
    {
        private readonly IRespositony<Payments> _respositony;

        public UpdatePaymentsCommandHandler(IRespositony<Payments> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Payments>> Handle(UpdatePaymentsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}