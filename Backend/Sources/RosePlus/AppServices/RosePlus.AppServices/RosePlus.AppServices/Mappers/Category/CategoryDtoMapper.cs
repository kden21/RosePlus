using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Category;

public static class CategoryDtoMapper
{
    public static void FillCategoryDto(this CategoryDto categoryDto, CategoryEntity categoryEntity)
    {
        categoryDto.Id = categoryEntity.Id;
        categoryDto.Name = categoryEntity.Name;
        categoryDto.ParentCategoryId = categoryEntity.ParentCategoryId;
        categoryDto.IsChildCategoriesExist = categoryEntity.ChildCategories.Any();
    }
}