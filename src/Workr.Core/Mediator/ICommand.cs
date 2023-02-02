using MediatR;

namespace Workr.Core.Mediator;

public interface ICommand<out TResponse> : IRequest<TResponse> where TResponse : Result
{

}