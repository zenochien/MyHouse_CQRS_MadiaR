using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRoomsCommand : IRequestWrapper<Rooms>
    {
    }

    public class CreateRoomsCommandHandler : IHandlerWrapper<CreateRoomsCommand, Rooms>
    {
        public async Task<Response<Rooms>> Handle(CreateRoomsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Rooms>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new Rooms { }, "Rooms Created"));
        }
    }
}
