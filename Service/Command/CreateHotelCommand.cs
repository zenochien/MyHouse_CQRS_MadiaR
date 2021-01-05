using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateHotelCommand : IRequestWrapper<Hotels>
    {
    }

    public class CreateHotelCommandHandler : IHandlerWrapper<CreateHotelCommand, Hotels>
    {
        public async Task<Response<Hotels>> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Hotels>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new Hotels { City = "asdfsdf", Address = "adfsfsd", Address2 = "asdfsdf" }, "Ok rồi"));
        }
    }
}
