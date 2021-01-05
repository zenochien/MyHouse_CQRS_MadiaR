using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateBookingCommand : IRequestWrapper<Booking>
    {
        public Booking Entity { get; set; }
    }

    public class UpdateBookingCommandHandler : IHandlerWrapper<UpdateBookingCommand, Booking>
    {
        private readonly IRespositony<Booking> _respositony;

        public UpdateBookingCommandHandler(IRespositony<Booking> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Booking>> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var result =await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity,string.Empty);
        }
    }
}
