using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteHotelsCommand : IRequestWrapper<Hotels>
    {
        public Hotels Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteHotelsCommandHandler : IHandlerWrapper<DeleteHotelsCommand, Hotels>
    {
        private readonly IRespositony<Hotels> _respositony;

        public DeleteHotelsCommandHandler(IRespositony<Hotels> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Hotels>> Handle(DeleteHotelsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
