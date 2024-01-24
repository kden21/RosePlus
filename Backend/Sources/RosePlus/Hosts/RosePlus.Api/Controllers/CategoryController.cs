using Microsoft.AspNetCore.Mvc;
using RosePlus.AppServices.Services.Category;
using RosePlus.Contracts.ApiResult;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Filters;

namespace RosePlus.Api.Controllers;

/// <summary>
/// Работа с категорией.
/// </summary>
[ApiController]
[Route("v1/[controller]/[action]")]
public class CategoryController : BaseController
{
    /// <summary>
    /// Сервис категорий.
    /// </summary>
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    /// <summary>
    /// Метод для получения категории по идентификатору.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet("{categoryId:int}", Name = "GetCategoryById")]
    [ProducesResponseType(typeof(ApiResult<CategoryDto>), statusCode: 200)]
    public async Task<IActionResult> GetCategoryByIdAsync(int categoryId, CancellationToken cancellation)
    {
        return Success(await _categoryService.GetCategoryByIdAsync(categoryId, cancellation));
    }
    
    /// <summary>
    /// Метод для получения коллекции категорий.
    /// </summary>
    /// <param name="filter">Параметры для фильтрации.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns>Результат.</returns>
    [HttpGet(Name = "GetCategories")]
    [ProducesResponseType(typeof(IReadOnlyCollection<CategoryDto>), statusCode: 200)]
    public async Task<IActionResult> GetCategoriesAsync([FromQuery]CategoryFilter filter, CancellationToken cancellation)
    {
        return Success(await _categoryService.GetAllCategoriesAsync(filter, cancellation));
    }
    
    /// <summary>
    /// Метод для обновления категории.
    /// </summary>
    /// <param name="categoryDto">Моель представления категории.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns></returns>
    [HttpPut(Name = "UpdateCategory")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> UpdateCategoryAsync([FromBody] CategoryDto categoryDto, CancellationToken cancellation)
    {
        await _categoryService.UpdateCategoryAsync(categoryDto, cancellation);
        return Success();
    }
    
    /// <summary>
    /// Метод для добавления категории.
    /// </summary>
    /// <param name="categoryDto">Модель представления категории.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns></returns>
    [HttpPost(Name = "AddCategory")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> AddCategoryAsync([FromBody] CategoryDto categoryDto, CancellationToken cancellation)
    {
        return Success(await _categoryService.AddCategoryAsync(categoryDto, cancellation));
    }
    
    /// <summary>
    /// Метод для уаления категории.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <param name="cancellation">Токен отмены действия.</param>
    /// <returns></returns>
    [HttpDelete("{categoryId:int}", Name = "DeleteCategory")]
    [ProducesResponseType(typeof(int), statusCode: 200)]
    public async Task<IActionResult> DeleteCategoryAsync(int categoryId, CancellationToken cancellation)
    {
        await _categoryService.DeleteCategoryAsync(categoryId, cancellation);
        return Success();
    }
}