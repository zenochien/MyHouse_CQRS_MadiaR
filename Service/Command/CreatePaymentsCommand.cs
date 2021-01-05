using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreatePaymentsCommand : IRequestWrapper<Payments>
    {
    }

    public class CreatePaymentsCommandHandler : IHandlerWrapper<CreatePaymentsCommand, Payments>
    {
        public async Task<Response<Payments>> Handle(CreatePaymentsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Payments>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new Payments { }, "Đã thành công"));
        }
    }
}
