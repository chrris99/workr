using MediatR;
using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;

namespace Workr.Application.Behaviors;

public sealed class LoggingPipelineBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : Result
{
    private readonly ILogger<LoggingPipelineBehavior<TRequest, TResponse>> _logger;

    public LoggingPipelineBehavior(ILogger<LoggingPipelineBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var requestName = request.GetType().Name;

        _logger.LogInformation("Handling request {requestName}", requestName);

        var result = await next();

        if (result.IsFailure)
            _logger.LogError("Handling request {requestName} failed with error {error}",
                requestName,
                result.Error);

        if (result.IsSuccess)
            _logger.LogInformation("Handling request {requestName} completed successfully", requestName);

        return result;
    }
}