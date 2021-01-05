using Service.Data;
using Service.Respone;
using Service.Wrappers;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Command
{
    public class CreateRateTypesCommand : IRequestWrapper<RateTypes>
    {
    }

    public class CreateRateTypesCommandHandler : IHandlerWrapper<CreateRateTypesCommand, RateTypes>
    {
        public async Task<Response<RateTypes>> Handle(CreateRateTypesCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return await Task.FromResult(Response.Fail<RateTypes>("alrealy exists"));
            }

            return await Task.FromResult(Response.Ok(new RateTypes { Active="123123", Description="asd" }, "RateTypes Created"));
        }
    }
}
