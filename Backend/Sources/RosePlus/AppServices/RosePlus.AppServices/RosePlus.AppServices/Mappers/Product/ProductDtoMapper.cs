using RosePlus.AppServices.Mappers.DateTimeMapper;
using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Product;

/// <summary>
/// Маппер для <see cref="ProductDto"/>
/// </summary>
public static class ProductDtoMapper
{
    public static void FillProductDto(this ProductDto productDto, ProductEntity productEntity)
    {
        productDto.Id = productEntity.Id;
        productDto.Name = productEntity.Name;
        productDto.Description = productEntity.Description;
        productDto.Count = productEntity.Count;
        productDto.Price = productEntity.Price;
        productDto.CategoryId = productEntity.CategoryId;
        productDto.Status = (int)productEntity.Status;
        productDto.CreateDate = productEntity.CreateDate.ToISOString();
        productDto.ModifyDate = productEntity.ModifyDate.ToISOString();
    }
}