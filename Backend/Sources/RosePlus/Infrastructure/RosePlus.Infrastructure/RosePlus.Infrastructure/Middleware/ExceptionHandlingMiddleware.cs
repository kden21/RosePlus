using System.Net.Mime;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RosePlus.AppServices.LoggerDb;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Exceptions;

namespace RosePlus.Infrastructure.Middleware;

/// <summary>
/// Middleware для обработки ошибок.
/// </summary>
public class ExceptionHandlingMiddleware
{
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;
    private readonly RequestDelegate _next;
    private JsonSerializerOptions _jsonSerializerOptions;

    public ExceptionHandlingMiddleware(
        RequestDelegate next, 
        ILogger<ExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
        _jsonSerializerOptions = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All, UnicodeRanges.All),
            WriteIndented = true
        };
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (BaseException baseException)
        {
            context.Response.StatusCode = StatusCodes.Status200OK;
            
            _logger.Log(LogLevel.Error, baseException.Message);
            
            await context.Response.WriteAsync( JsonSerializer.Serialize(new ApiResult<ApiError>{
                Data = new ApiError
                {
                    Message = baseException.UserMessage,
                    TraceId = context.TraceIdentifier
                },
                IsSuccess = false,
            }, _jsonSerializerOptions));
        }
        catch (Exception exception)
        {
            context.Response.ContentType = MediaTypeNames.Application.Json;
            
            _logger.Log(LogLevel.Critical, exception.Message);
            
            await context.Response.WriteAsync( JsonSerializer.Serialize(new ApiResult<ApiError>{
                Data = new ApiError
                {
                    Message = "Произошла непредвиденная ошибка.",
                    TraceId = context.TraceIdentifier
                },
                IsSuccess = false,
            }, _jsonSerializerOptions));
        }
    }
}