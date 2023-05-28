using Microsoft.AspNetCore.Mvc;
using RosePlus.AppServices.Services.AttributeValue;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Dto;

namespace RosePlus.Api.Controllers;

public class AttributeValueController : BaseController
{
    private readonly IAttributeValueService _attributeValueService;

    public AttributeValueController(IAttributeValueService attributeValueService)
    {
        _attributeValueService = attributeValueService;
    }

    /// <summary>
    /// Метод для получения значения атрибута по идентификатору.
    /// </summary>
    /// <param name="attributeValueId">Идентификатор значения атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet("{attributeValueId:int}", Name = "GetAttributeValueById")]
    [ProducesResponseType(typeof(ApiResult<AttributeValueDto>), statusCode: 200)]
    public async Task<IActionResult> GetAttributeValueByIdAsync(int attributeValueId, CancellationToken cancellation)
    {
        return Success(await _attributeValueService.GetAttributeValueByIdAsync(attributeValueId, cancellation));
    }
    
    /// <summary>
    /// Метод для получения коллекции значений атрибута.
    /// </summary>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet(Name = "GetAttributeValues")]
    [ProducesResponseType(typeof(IReadOnlyCollection<AttributeValueDto>), statusCode: 200)]
    public async Task<IActionResult> GetAttributeValuesAsync(CancellationToken cancellation)
    {
        return Success(await _attributeValueService.GetAttributeValuesAsync(cancellation));
    }
    
    /// <summary>
    /// Метод для обновления значения атрибута.
    /// </summary>
    /// <param name="attributeValueDto">Модель представления значения атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpPut(Name = "UpdateAttributeValue")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> UpdateAttributeValueAsync([FromBody] AttributeValueDto attributeValueDto, CancellationToken cancellation)
    {
        await _attributeValueService.UpdateAttributeValueAsync(attributeValueDto, cancellation);
        return Success();
    }
    
    /// <summary>
    /// Метод для добавления значения атрибута.
    /// </summary>
    /// <param name="attributeValueDto">Модель представления значения атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns></returns>
    [HttpPost(Name = "AddAttributeValue")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> AddAttributeValueAsync([FromBody] AttributeValueDto attributeValueDto, CancellationToken cancellation)
    {
        return Success(await _attributeValueService.AddAttributeValueAsync(attributeValueDto, cancellation));
    }
    
    /// <summary>
    /// Метод для удаления значения атрибута.
    /// </summary>
    /// <param name="attributeValueId">Идентификатор значения атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpDelete("{attributeValueId:int}", Name = "DeleteAttributeValue")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> DeleteAttributeValueAsync(int attributeValueId, CancellationToken cancellation)
    {
        await _attributeValueService.DeleteAttributeValueAsync(attributeValueId, cancellation);
        return Success();
    }   
}