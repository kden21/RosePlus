using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Repositories;

/// <summary>
/// Репозиторий для работы с категориями <see cref="CategoryEntity"/>>
/// </summary>
public interface ICategoryRepository
{
    /// <summary>
    /// Метод получения категории по идентификатору.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Сущность категории.</returns>
    Task<CategoryEntity> GetCategoryById(int categoryId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для получения всех категорий.
    /// </summary>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    /// <returns>Список категорий.</returns>
    Task<List<CategoryEntity>> GetAllCategories(CancellationToken cancellationToken);

    /// <summary>
    /// Метод добавления категории.
    /// </summary>
    /// <param name="categoryEntity">Сущность категории.</param>
    /// <param name="cancellationToken"Токен отмены действия.</param>
    /// <returns>Иденификатор категории.</returns>
    Task<int> AddCategory(CategoryEntity categoryEntity, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для удаления категории.
    /// </summary>
    /// <param name="categoryId">Идентификатор категории.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task DeleteCategory(int categoryId, CancellationToken cancellationToken);

    /// <summary>
    /// Метод для изменения категории.
    /// </summary>
    /// <param name="categoryEntity">Модель представления категории.</param>
    /// <param name="cancellationToken">Токен отмены действия.</param>
    Task UpdateCategory(CategoryEntity categoryEntity, CancellationToken cancellationToken);
}