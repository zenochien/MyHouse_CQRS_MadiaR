using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRateTypesCommand : IRequestWrapper<RateTypes>
    {
        public RateTypes Entity { get; set; }
    }

    public class CreateRateTypesCommandHandler : IHandlerWrapper<CreateRateTypesCommand, RateTypes>
    {
        private readonly IRespositony<RateTypes> _respositony;

        public CreateRateTypesCommandHandler(IRespositony<RateTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RateTypes>> Handle(CreateRateTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
