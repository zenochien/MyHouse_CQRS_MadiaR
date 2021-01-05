using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateGuestsCommand : IRequestWrapper<Guests>
    {
        public Guests Entity { get; set; }
    }

    public class CreateGuestsCommandHandler : IHandlerWrapper<CreateGuestsCommand, Guests>
    {
        private readonly IRespositony<Guests> _respositony;

        public CreateGuestsCommandHandler(IRespositony<Guests> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Guests>> Handle(CreateGuestsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
