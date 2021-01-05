using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeletePositionsCommand : IRequestWrapper<Positions>
    {
        public Positions Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeletePositionsCommandHandler : IHandlerWrapper<DeletePositionsCommand, Positions>
    {
        private readonly IRespositony<Positions> _respositony;

        public DeletePositionsCommandHandler(IRespositony<Positions> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Positions>> Handle(DeletePositionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
