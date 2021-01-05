using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRatesCommand : IRequestWrapper<Rates>
    {
    }

    public class CreateRatesCommandHandler : IHandlerWrapper<CreateRatesCommand, Rates>
    {
        public CreateRatesCommandHandler()
        {
        }

        public async Task<Response<Rates>> Handle(CreateRatesCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Rates>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new Rates { }, "Đã thành công"));
        }
    }
}
