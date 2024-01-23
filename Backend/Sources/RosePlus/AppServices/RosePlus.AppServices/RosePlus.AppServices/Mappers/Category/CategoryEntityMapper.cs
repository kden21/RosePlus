using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Category;

public static class CategoryEntityMapper
{
    public static void FillCategoryEntity(this  CategoryEntity categoryEntity, CategoryDto categoryDto)
    {
        categoryEntity.Id = categoryDto.Id ?? 0;
        categoryEntity.Name = categoryDto.Name;
        categoryEntity.ParentCategoryId ??= categoryDto.ParentCategoryId;
    }
}