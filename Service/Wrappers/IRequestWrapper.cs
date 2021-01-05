using MediatR;
using Service.Respone;

namespace Service.Wrappers
{
    public interface IRequestWrapper<T> : IRequest<Response<T>>
    { }

    public interface IHandlerWrapper<T_In, T_Out> : IRequestHandler<T_In, Response<T_Out>>
        where T_In : IRequestWrapper<T_Out>
    { }
}