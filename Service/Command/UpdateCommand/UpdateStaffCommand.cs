using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.UpdateCommand
{
    public class UpdateStaffCommand : IRequestWrapper<Staff>
    {
        public Staff Entity { get; set; }
    }

    public class UpdateStaffCommandHandler : IHandlerWrapper<UpdateStaffCommand, Staff>
    {
        private readonly IRespositony<Staff> _respositony;

        public UpdateStaffCommandHandler(IRespositony<Staff> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Staff>> Handle(UpdateStaffCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.UpdateAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
