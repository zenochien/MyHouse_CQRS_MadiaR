using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public  class CreatePositionsCommand : IRequestWrapper<Positions>
    {
    }

    public class CreatePositionsCommandHandler : IHandlerWrapper<CreatePositionsCommand, Positions>
    {
        public async Task<Response<Positions>> Handle(CreatePositionsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Positions>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new Positions { }, "Đã thành công"));
        }
    }
}
