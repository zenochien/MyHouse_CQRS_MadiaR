using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateReservationAgentsCommand : IRequestWrapper<ReservationAgents>
    {
        public ReservationAgents Entity { get; set; }
    }

    public class CreateReservationAgentsCommandHandler : IHandlerWrapper<CreateReservationAgentsCommand, ReservationAgents>
    {
        private readonly IRespositony<ReservationAgents> _respositony;

        public CreateReservationAgentsCommandHandler(IRespositony<ReservationAgents> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<ReservationAgents>> Handle(CreateReservationAgentsCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}
