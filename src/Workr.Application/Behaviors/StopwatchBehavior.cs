using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Workr.Core;
using Workr.Core.Mediator;

namespace Workr.Application.Behaviors;

public class StopwatchBehavior<TRequest, TResponse> : IBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : Result
{
    private readonly ILogger<StopwatchBehavior<TRequest, TResponse>> _logger;

    public StopwatchBehavior(ILogger<StopwatchBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var requestName = request.GetType().Name;
        var stopwatch = new Stopwatch();

        stopwatch.Start();

        var result = await next();

        if (result.IsSuccess)
            _logger.LogInformation("Handling request {requestName} completed successfully in {duration} ms",
                requestName,
                stopwatch.ElapsedMilliseconds);

        if (result.IsFailure)
            _logger.LogError("Handling request {requestName} failed in {duration} ms",
                requestName,
                stopwatch.ElapsedMilliseconds);

        return result;
    }
}