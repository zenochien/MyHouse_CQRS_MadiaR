using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateStaffCommand : IRequestWrapper<Staff>
    {
    }

    public class CreateStaffCommandHandler : IHandlerWrapper<CreateStaffCommand, Staff>
    {
        public async Task<Response<Staff>> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<Staff>("alrealy exists"));
            }
            return await Task.FromResult(Response.Ok(new Staff { }, "Đã thành công"));
        }
    }
}

