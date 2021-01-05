using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Data
{
    public class CreateBookingCommand : IRequestWrapper<Booking>
    {
        public Booking Entity { get; set; }
    }

    public class CreateBookingCommandHandler : IHandlerWrapper<CreateBookingCommand, Booking>
    {
        private readonly IRespositony<Booking> _respositony;

        public CreateBookingCommandHandler(IRespositony<Booking> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Booking>> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return  Response.Ok(result, string.Empty);
            
        }
    }
}