using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePositionsCommand : IRequestWrapper<Positions>
    {
        public Positions Entity { get; set; }
    }

    public class CreatePositionsCommandHandler : IHandlerWrapper<CreatePositionsCommand, Positions>
    {
        private readonly IRespositony<Positions> _respositony;

        public CreatePositionsCommandHandler(IRespositony<Positions> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Positions>> Handle(CreatePositionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
