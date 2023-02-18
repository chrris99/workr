using MediatR;
using Microsoft.Extensions.Logging;
using Workr.Core;
using Workr.Core.Mediator;

namespace Workr.Application.Behaviors;

public sealed class LoggingBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : Result
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var requestName = request.GetType().Name;

        _logger.LogInformation("Handling request {requestName} started", requestName);

        var result = await next();

        if (result.IsFailure)
            _logger.LogError("Handling request {requestName} failed with the following error: {error}",
                requestName,
                result.Error.Message);

        if (result.IsSuccess)
            _logger.LogInformation("Handling request {requestName} completed successfully", requestName);

        return result;
    }
}