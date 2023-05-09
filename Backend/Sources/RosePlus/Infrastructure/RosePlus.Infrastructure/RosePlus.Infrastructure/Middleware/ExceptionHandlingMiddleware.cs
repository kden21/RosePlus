using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Exceptions;

namespace RosePlus.Infrastructure.Middleware;

/// <summary>
/// Middleware для обработки ошибок.
/// </summary>
public class ExceptionHandlingMiddleware
{
     private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (BaseException exception)
        {
            context.Response.StatusCode = StatusCodes.Status200OK;//;.Status404NotFound;
            await context.Response.WriteAsync( JsonSerializer.Serialize(new ApiResult<string>
            {
                //Message = exception.,
                IsSuccess = false,
            }));
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            context.Response.ContentType = MediaTypeNames.Application.Json;
            
            switch (exception)
            {
                case EntityNotFoundException:
                    context.Response.StatusCode = StatusCodes.Status200OK;//;.Status404NotFound;
                    await context.Response.WriteAsync( JsonSerializer.Serialize(new ApiResult<string>
                    {
                        Message = exception.Message,
                        IsSuccess = false,
                    }));
                    break;
                case EntityUpdateException:
                    context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                    await context.Response.WriteAsync( JsonSerializer.Serialize(new
                    {
                        traceId = context.TraceIdentifier, 
                        message = exception.Message
                    }));
                    break;
                case EntityCreateException:
                    context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                    await context.Response.WriteAsync( JsonSerializer.Serialize(new
                    {
                        traceId = context.TraceIdentifier, 
                        message = exception.Message
                    }));
                    break;
                case WrongDataException:
                    context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                    await context.Response.WriteAsync( JsonSerializer.Serialize(new
                    {
                        traceId = context.TraceIdentifier, 
                        message = exception.Message
                    }));
                    break;
                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    await context.Response.WriteAsync( JsonSerializer.Serialize(new
                    {
                        traceId = context.TraceIdentifier, 
                        message = "Произошла непредвиденная ошибка."
                    }));
                    break;
            }
        }
    }
}