using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Product;

public static class ProductDtoMapper
{
    public static ProductDto FillDto(this ProductEntity productEntity)
    {
        return new ProductDto
        {
            Id = productEntity.Id,
            CreateDate = productEntity.CreateDate.ToString("yyyy-MM-dd"),
            ModifyDate = productEntity.ModifyDate.ToString("yyyy-MM-dd"),
            Name = productEntity.Name,
            Description = productEntity.Description,
            Price = productEntity.Price,
            Count = productEntity.Count
        };
    }
}