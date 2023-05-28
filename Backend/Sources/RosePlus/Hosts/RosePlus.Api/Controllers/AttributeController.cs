using Microsoft.AspNetCore.Mvc;
using RosePlus.AppServices.Services.Attribute;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Dto;

namespace RosePlus.Api.Controllers;

public class AttributeController : BaseController
{
    private readonly IAttributeService _attributeService;

    public AttributeController(IAttributeService attributeService)
    {
        _attributeService = attributeService;
    }

    /// <summary>
    /// Метод для получения атрибута по идентификатору.
    /// </summary>
    /// <param name="attributeId">Идентификатор атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet("{attributeId:int}", Name = "GetAttributeById")]
    [ProducesResponseType(typeof(ApiResult<AttributeDto>), statusCode: 200)]
    public async Task<IActionResult> GetAttributeByIdAsync(int attributeId, CancellationToken cancellation)
    {
        return Success(await _attributeService.GetAttributeByIdAsync(attributeId, cancellation));
    }
    
    /// <summary>
    /// Метод для получения коллекции атрибутов.
    /// </summary>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet(Name = "GetAttributes")]
    [ProducesResponseType(typeof(IReadOnlyCollection<AttributeDto>), statusCode: 200)]
    public async Task<IActionResult> GetAttributesAsync(CancellationToken cancellation)
    {
        return Success(await _attributeService.GetAttributesAsync(cancellation));
    }
    
    /// <summary>
    /// Метод для обновления атрибута.
    /// </summary>
    /// <param name="attributeDto">Модель представления атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpPut(Name = "UpdateAttribute")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> UpdateAttributeAsync([FromBody] AttributeDto attributeDto, CancellationToken cancellation)
    {
        await _attributeService.UpdateAttributeAsync(attributeDto, cancellation);
        return Success();
    }
    
    /// <summary>
    /// Метод для добавления атрибута.
    /// </summary>
    /// <param name="attributeDto">Модель представления атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpPost(Name = "AddAttribute")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> AddAttributeAsync([FromBody] AttributeDto attributeDto, CancellationToken cancellation)
    {
        return Success(await _attributeService.AddAttributeAsync(attributeDto, cancellation));
    }
    
    /// <summary>
    /// Метод для удаления атрибута.
    /// </summary>
    /// <param name="attributeId">Идентификатор атрибута.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpDelete("{attributeId:int}", Name = "DeleteAttribute")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> DeleteAttributeAsync(int attributeId, CancellationToken cancellation)
    {
        await _attributeService.DeleteAttributeAsync(attributeId, cancellation);
        return Success();
    }
}