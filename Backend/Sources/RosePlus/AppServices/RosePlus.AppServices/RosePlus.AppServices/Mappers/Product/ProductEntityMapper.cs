using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Product;

public static class ProductEntityMapper
{
    public static ProductEntity FillEntity(this ProductDto productDto)
    {
        return new ProductEntity
        {
            Id = productDto.Id,
            CreateDate = DateTime.ParseExact(productDto.ModifyDate, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture),
            ModifyDate = DateTime.ParseExact(productDto.ModifyDate, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture),
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price,
            Count = productDto.Count,
            CategoryId = productDto.CategoryId
        };
    }
}