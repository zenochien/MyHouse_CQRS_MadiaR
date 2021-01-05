using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteGuestCommand : IRequestWrapper<Guests>
    {
        public Guests Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteGuestsCommandHandler : IHandlerWrapper<DeleteGuestCommand, Guests>
    {
        private readonly IRespositony<Guests> _respositony;

        public DeleteGuestsCommandHandler(IRespositony<Guests> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Guests>> Handle(DeleteGuestCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
