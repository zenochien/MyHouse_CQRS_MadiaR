using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePaymentsCommand : IRequestWrapper<Payments>
    {
        public Payments Entity { get; set; }
    }

    public class CreatePaymentsCommandHandler : IHandlerWrapper<CreatePaymentsCommand, Payments>
    {
        private readonly IRespositony<Payments> _respositony;

        public CreatePaymentsCommandHandler(IRespositony<Payments> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Payments>> Handle(CreatePaymentsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
