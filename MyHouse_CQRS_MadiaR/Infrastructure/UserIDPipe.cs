using MediatR;
using Microsoft.AspNetCore.Http;
using Service.Data;
using Service.Respone;
using System.Threading;
using System.Threading.Tasks;

namespace MyHouse_CQRS_MadiaR.Infrastructure
{
    public class UserIDPipe<T_In, T_Out> : IPipelineBehavior<T_In, T_Out>
    {
        private HttpContext _httpContext;

        public UserIDPipe(IHttpContextAccessor accessor )
        {
            _httpContext = accessor.HttpContext;
        }
        public async Task<T_Out> Handle(T_In request, CancellationToken cancellationToken, RequestHandlerDelegate<T_Out> next)
        {
            //var userID = _httpContext.User.Claims
            //    .FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier))
            //    .Value;

            var result = await next();

            if(result is Response<Guests> guestsResponse)
            {
                guestsResponse.Data.FirstName += "Chao ban";
            }

            return result;
        }
    }
}
