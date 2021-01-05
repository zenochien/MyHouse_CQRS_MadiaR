using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateHotelsCommand : IRequestWrapper<Hotels>
    {
        public Hotels Entity { get; set; }
    }

    public class UpdateHotelsCommandHandler : IHandlerWrapper<UpdateHotelsCommand, Hotels>
    {
        private readonly IRespositony<Hotels> _respositony;

        public UpdateHotelsCommandHandler(IRespositony<Hotels> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Hotels>> Handle(UpdateHotelsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
