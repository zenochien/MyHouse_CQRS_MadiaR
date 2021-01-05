using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Commad
{
    public class CreateGuestsCommand : IRequestWrapper<Guests>
    {
    }

    public class CreateGuestsCommandHandler : IHandlerWrapper<CreateGuestsCommand, Guests>
    {
        public async Task<Response<Guests>> Handle(CreateGuestsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Guests>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new Guests { FirstName = "Thurs Mansap", City = "New York" }, "Guests Created"));
        }
    }
}
