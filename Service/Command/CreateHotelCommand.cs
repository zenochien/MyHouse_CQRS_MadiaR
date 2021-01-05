using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateHotelsCommand : IRequestWrapper<Hotels>
    {
    }

    public class CreateHotelsCommandHandler : IHandlerWrapper<CreateHotelsCommand, Hotels>
    {
        public async Task<Response<Hotels>> Handle(CreateHotelsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Hotels>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new Hotels { Address="sfsfs", Address2="dfasdfs",City="dfsfs" }, "Hotels Created"));
        }
    }
}
