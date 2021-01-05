using Service.Data;
using Service.Respone;
using Service.Resposition;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateStaffCommand : IRequestWrapper<Staff>
    {
        public Staff Entity { get; set; }
    }

    public class CreateStaffCommandHandler : IHandlerWrapper<CreateStaffCommand, Staff>
    {
        private readonly IRespositony<Staff> _respositony;

        public CreateStaffCommandHandler(IRespositony<Staff> respositony)
        {
            _respositony = respositony;
        }

        public async Task<Response<Staff>> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            var result = await _respositony.AddAsync(request.Entity, cancellationToken);
            return Response.Ok(result, string.Empty);

        }
    }
}

