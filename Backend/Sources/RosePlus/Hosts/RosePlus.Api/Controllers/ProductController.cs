using System.Net;
using Microsoft.AspNetCore.Mvc;
using RosePlus.AppServices.Services;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Requests;

namespace RosePlus.Api.Controllers;

/// <summary>
/// Работа с товаром.
/// </summary>
[ApiController]
[Route("v1/[controller]")]
public class ProductController : BaseController
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductService _productService;

    public ProductController(
        ILogger<ProductController> logger, 
        IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }
    
    /// <summary>
    /// Метод для получения товара по идентификатору.
    /// </summary>
    /// <param name="productId">Идентификатор товара.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet("{productId:int}", Name = "GetProductById")]
    [ProducesResponseType(typeof(ApiResult<ProductDto>), statusCode: 200)]
    public async Task<IActionResult> GetProductByIdAsync([FromQuery] int productId, CancellationToken cancellation)
    {
        
        _logger.Log( LogLevel.Critical,"dddd");
        var data = await _productService.GetProductByIdAsync(productId, cancellation);

        return Success();
    }
    
    /// <summary>
    /// Метод для получения коллекции товаров.
    /// </summary>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet(Name = "GetProducts")]
    [ProducesResponseType(typeof(IReadOnlyCollection<ProductDto>), statusCode: 200)]
    public async Task<IActionResult> GetProductsAsync([FromQuery] ProductRequest productRequest,CancellationToken cancellation)
    {
        var data = await _productService.GetProductsAsync(productRequest, cancellation);
        return Ok(data);
    }
    
    [HttpPost(Name = "AddProduct")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> AddProductAsync([FromBody] ProductDto productDto, CancellationToken cancellation)
    {
        var data = await _productService.AddProductAsync(productDto, cancellation);
        return Ok(data);
    }
}