using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateReservationAgentsCommand : IRequestWrapper<ReservationAgents>
    {
    }

    public class CreateReservationAgentsCommandHanler : IHandlerWrapper<CreateReservationAgentsCommand, ReservationAgents>
    {
        public async Task<Response<ReservationAgents>> Handle(CreateReservationAgentsCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<ReservationAgents>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new ReservationAgents { Address2 = "sdfsd", Address = "sdfsdfe", State = "sdfsdfsdde" }, "Created"));
        }
    }
}
