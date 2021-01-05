using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateGuestsCommand : IRequestWrapper<Guests>
    {
        public Guests Entity { get; set; }
    }

    public class UpdateGuestsCommandHandler : IHandlerWrapper<UpdateGuestsCommand, Guests>
    {
        private readonly IRespositony<Guests> _respositony;

        public UpdateGuestsCommandHandler(IRespositony<Guests> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Guests>> Handle(UpdateGuestsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
