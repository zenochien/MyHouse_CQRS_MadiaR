using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
   public class UpdateRateTypesCommand : IRequestWrapper<RateTypes>
    {
        public RateTypes Entity { get; set; }
    }

    public class UpdateRateTypesCommandHandler : IHandlerWrapper<UpdateRateTypesCommand, RateTypes>
    {
        private readonly IRespositony<RateTypes> _respositony;

        public UpdateRateTypesCommandHandler(IRespositony<RateTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RateTypes>> Handle(UpdateRateTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
