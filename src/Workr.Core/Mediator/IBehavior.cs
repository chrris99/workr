using MediatR;

namespace Workr.Core.Mediator;

public interface IBehavior<in TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : Result
{

}