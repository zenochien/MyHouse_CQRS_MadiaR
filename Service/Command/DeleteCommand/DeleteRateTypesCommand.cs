using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteRateTypesCommand : IRequestWrapper<RateTypes>
    {
        public RateTypes Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteRateTypesCommandHandler : IHandlerWrapper<DeleteRateTypesCommand, RateTypes>
    {
        private readonly IRespositony<RateTypes> _respositony;

        public DeleteRateTypesCommandHandler(IRespositony<RateTypes> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<RateTypes>> Handle(DeleteRateTypesCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
