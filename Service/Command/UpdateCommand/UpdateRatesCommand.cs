using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateRatesCommand : IRequestWrapper<Rates>
    {
        public Rates Entity { get; set; }
    }

    public class UpdateRatesCommandHandler : IHandlerWrapper<UpdateRatesCommand, Rates>
    {
        private readonly IRespositony<Rates> _respositony;

        public UpdateRatesCommandHandler(IRespositony<Rates> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Rates>> Handle(UpdateRatesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
