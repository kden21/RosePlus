using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Filters;

namespace RosePlus.AppServices.Services.Category;

/// <summary>
/// Сервис для работы с категориями.
/// </summary>
public interface ICategoryService
{
    /// <summary>
    /// Метод получения категории по идентификатору.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Категория.</returns>
    Task<CategoryDto> GetCategoryByIdAsync(int categoryId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для получения всех категорий.
    /// </summary>
    /// <param name="filter">Параметры фильтрации.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Список категорий.</returns>
    Task<List<CategoryDto>> GetAllCategoriesAsync(CategoryFilter filter, CancellationToken cancellationToken);

    /// <summary>
    /// Метод добавления категории.
    /// </summary>
    /// <param name="categoryDto">Категория.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Иденификатор категории.</returns>
    Task<int> AddCategoryAsync(CategoryDto categoryDto, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для удаления категории.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteCategoryAsync(int categoryId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения категории.
    /// </summary>
    /// <param name="categoryDto">Модель представления категории.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateCategoryAsync(CategoryDto categoryDto, CancellationToken cancellationToken);
}