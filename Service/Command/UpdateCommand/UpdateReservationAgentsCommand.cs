using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateReservationAgentsCommand : IRequestWrapper<ReservationAgents>
    {
        public ReservationAgents Entity { get; set; }
    }

    public class UpdateReservationAgentsCommandHandler : IHandlerWrapper<UpdateReservationAgentsCommand, ReservationAgents>
    {
        private readonly IRespositony<ReservationAgents> _respositony;

        public UpdateReservationAgentsCommandHandler(IRespositony<ReservationAgents> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<ReservationAgents>> Handle(UpdateReservationAgentsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
