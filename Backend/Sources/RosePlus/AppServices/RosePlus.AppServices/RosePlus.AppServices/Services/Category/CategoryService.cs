using RosePlus.AppServices.Mappers.Category;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Filters;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Services.Category;

/// <inheritdoc />
public class CategoryService : ICategoryService
{
    /// <summary>
    /// Репозиторий для работы с категориями.
    /// </summary>
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    /// <inheritdoc />
    public async Task<CategoryDto> GetCategoryByIdAsync(int categoryId, CancellationToken cancellationToken)
    {
        CategoryEntity categoryEntity = await _categoryRepository.GetCategoryById(categoryId, cancellationToken);
        CategoryDto categoryDto = new CategoryDto();
        categoryDto.FillCategoryDto(categoryEntity);
        return categoryDto;
    }
    
    /// <inheritdoc />
    public async Task<List<CategoryDto>> GetAllCategoriesAsync(CategoryFilter filter, CancellationToken cancellationToken)
    {
        IEnumerable<CategoryEntity> categoryEntities =  await _categoryRepository.GetAllCategories(filter, cancellationToken);
        List<CategoryDto> categoryDtos = new List<CategoryDto>();
        foreach (var categoryEntitiy in categoryEntities)
        {
            CategoryDto categoryDto = new CategoryDto();
            categoryDto.FillCategoryDto(categoryEntitiy);
            categoryDtos.Add(categoryDto);
        }

        return categoryDtos;
    }
    
    /// <inheritdoc />
    public async Task<int> AddCategoryAsync(CategoryDto categoryDto, CancellationToken cancellationToken)
    {
        CategoryEntity categoryEntity = new CategoryEntity();
        categoryEntity.FillCategoryEntity(categoryDto);
        categoryEntity.Id = 0;
        return await _categoryRepository.AddCategory(categoryEntity, cancellationToken);
    }

    /// <inheritdoc />
    public Task DeleteCategoryAsync(int categoryId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task UpdateCategoryAsync(CategoryDto categoryDto, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}