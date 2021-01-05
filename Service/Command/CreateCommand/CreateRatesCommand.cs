using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRatesCommand : IRequestWrapper<Rates>
    {
        public Rates Entity { get; set; }
    }

    public class CreateRatesCommandHandler : IHandlerWrapper<CreateRatesCommand, Rates>
    {
        private readonly IRespositony<Rates> _respositony;

        public CreateRatesCommandHandler(IRespositony<Rates> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Rates>> Handle(CreateRatesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
