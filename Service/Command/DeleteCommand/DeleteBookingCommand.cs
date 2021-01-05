using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteBookingCommand : IRequestWrapper<Booking>
    {
        public Booking Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteBookingCommandHandler : IHandlerWrapper<DeleteBookingCommand, Booking>
    {
        private readonly IRespositony<Booking> _respositony;

        public DeleteBookingCommandHandler(IRespositony<Booking> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Booking>> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
