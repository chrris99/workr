using System.Net;
using Workr.Core;

namespace Workr.Web.Middlewares;

public sealed class ExceptionHandlerMiddleware
{
    private ILogger<ExceptionHandlerMiddleware> _logger;
    private readonly RequestDelegate _next;

    /// <summary>
    /// Initializes a new instance of the <see cref="ExceptionHandlerMiddleware"/> class.
    /// </summary>
    /// <param name="next">The delegate pointing to the next middleware in the chain.</param>
    /// <param name="logger">The logger.</param>
    public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    /// <summary>
    /// Invokes the exception handler middleware with the specified <see cref="HttpContext"/>.
    /// </summary>
    /// <param name="httpContext">The HTTP httpContext.</param>
    /// <returns>The task that can be awaited by the next middleware.</returns>
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception occurred: {Message}", ex.Message);

            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
    {
        return exception switch
        {
            
        }
    }

    private (HttpStatusCode, Error) GetHttpStatusCodeAndError(Exception exception)
    {

    }
}