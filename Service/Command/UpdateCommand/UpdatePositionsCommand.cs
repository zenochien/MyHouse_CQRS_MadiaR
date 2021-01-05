using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdatePositionsCommand : IRequestWrapper<Positions>
    {
        public Positions Entity { get; set; }
    }

    public class UpdatePositionsCommandHandler : IHandlerWrapper<UpdatePositionsCommand, Positions>
    {
        private readonly IRespositony<Positions> _respositony;

        public UpdatePositionsCommandHandler(IRespositony<Positions> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Positions>> Handle(UpdatePositionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
