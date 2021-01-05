using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateHotelsCommand : IRequestWrapper<Hotels>
    {
        public Hotels Entity { get; set; }
    }

    public class CreateHotelsCommandHandler : IHandlerWrapper<CreateHotelsCommand, Hotels>
    {
        private readonly IRespositony<Hotels> _respositony;

        public CreateHotelsCommandHandler(IRespositony<Hotels> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Hotels>> Handle(CreateHotelsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
