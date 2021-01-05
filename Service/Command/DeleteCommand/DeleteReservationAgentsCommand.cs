using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteReservationAgentsCommand : IRequestWrapper<ReservationAgents>
    {
        public ReservationAgents Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteReservationAgentsCommandHandler : IHandlerWrapper<DeleteReservationAgentsCommand, ReservationAgents>
    {
        private readonly IRespositony<ReservationAgents> _respositony;

        public DeleteReservationAgentsCommandHandler(IRespositony<ReservationAgents> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<ReservationAgents>> Handle(DeleteReservationAgentsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
