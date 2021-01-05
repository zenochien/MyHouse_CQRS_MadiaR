using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand 
{
    public class DeleteRatesCommand : IRequestWrapper<Rates>
    {
        public Rates Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteRatesCommandHandler : IHandlerWrapper<DeleteRatesCommand, Rates>
    {
        private readonly IRespositony<Rates> _respositony;

        public DeleteRatesCommandHandler(IRespositony<Rates> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Rates>> Handle(DeleteRatesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
