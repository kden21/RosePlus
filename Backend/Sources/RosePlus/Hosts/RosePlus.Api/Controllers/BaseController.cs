using Microsoft.AspNetCore.Mvc;
using RosePlus.Contracts.ApiResult;

namespace RosePlus.Api.Controllers;

public class BaseController : ControllerBase
{
    /// <summary>
    /// Успешное завершение вызова.
    /// </summary>
    /// <typeparam name="T">Тип возвращаемых данных.</typeparam>
    /// <param name="data">Данные.</param>
    /// <returns>Результат вызова API.</returns>
    protected IActionResult Success<T>(T data)
    {
        return Ok(ApiResult<T>.SuccessResult(data));
    }

    /// <summary>
    /// Успешное завершение вызова.
    /// </summary>
    /// <returns>Результат вызова API.</returns>
    protected IActionResult Success()
    {
        return Ok(ApiResult<string>.SuccessResult(null));
    }
}