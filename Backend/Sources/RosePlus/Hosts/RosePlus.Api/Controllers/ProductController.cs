using Microsoft.AspNetCore.Mvc;
using RosePlus.AppServices.Services.Product;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Filters;

namespace RosePlus.Api.Controllers;

/// <summary>
/// Работа с товаром.
/// </summary>
[ApiController]
[Route("v1/[controller]/[action]")]
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
    public async Task<IActionResult> GetProductByIdAsync(int productId, CancellationToken cancellation)
    {
        return Success(await _productService.GetProductByIdAsync(productId, cancellation));
    }
    
    /// <summary>
    /// Метод для получения коллекции товаров.
    /// </summary>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet(Name = "GetProducts")]
    [ProducesResponseType(typeof(IReadOnlyCollection<ProductDto>), statusCode: 200)]
    public async Task<IActionResult> GetProductsAsync([FromQuery] ProductFilter productFilter, CancellationToken cancellation)
    {
        return Success(await _productService.GetProductsAsync(productFilter, cancellation));
    }
    
    [HttpPut(Name = "UpdateProduct")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> UpdateProductAsync([FromBody] ProductDto productDto, CancellationToken cancellation)
    {
        await _productService.UpdateProductAsync(productDto, cancellation);
        return Success();
    }
    
    [HttpPost(Name = "AddProduct")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> AddProductAsync([FromBody] ProductDto productDto, CancellationToken cancellation)
    {
        return Success(await _productService.AddProductAsync(productDto, cancellation));
    }
    
    [HttpDelete("{productId:int}", Name = "DeleteProduct")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> DeleteProductAsync(int productId, CancellationToken cancellation)
    {
        await _productService.DeleteProductAsync(productId, cancellation);
        return Success();
    }
}