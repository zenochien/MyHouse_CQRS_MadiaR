using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command.DeleteCommand
{
    public class DeleteStaffCommand : IRequestWrapper<Staff>
    {
        public Staff Entity { get; set; }
        public int Id { get; set; }
    }

    public class DeleteStaffCommandHandler : IHandlerWrapper<DeleteStaffCommand, Staff>
    {
        private readonly IRespositony<Staff> _respositony;

        public DeleteStaffCommandHandler(IRespositony<Staff> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Staff>> Handle(DeleteStaffCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.DeleteAsync(request.Entity);
            return Response.Ok(request.Entity, string.Empty);
        }
    }
}
