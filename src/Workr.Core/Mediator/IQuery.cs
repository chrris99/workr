using MediatR;

namespace Workr.Core.Mediator;

public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : Result
{

}