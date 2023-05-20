using RosePlus.AppServices.Mappers.DateTimeMapper;
using RosePlus.Contracts.Dto;
using RosePlus.Contracts.Enums;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Product;

/// <summary>
/// Маппер для <see cref="ProductEntity"/>>
/// </summary>
public static class ProductEntityMapper
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="productEntity"></param>
    /// <param name="productDto"></param>
    public static void FillProductEntity(this ProductEntity productEntity, ProductDto productDto)
    {
        productEntity.Id = productDto.Id;
        productEntity.Name = productDto.Name;
        productEntity.Description = productDto.Description;
        productEntity.Count = productDto.Count;
        productEntity.Price = productDto.Price;
        productEntity.CategoryId = productDto.CategoryId;
        productEntity.Status = (StatusProduct)productDto.Status;
        productEntity.CreateDate = productEntity.CreateDate == DateTime.MinValue
            ? (string.IsNullOrEmpty(productDto.CreateDate) ? DateTime.UtcNow : productDto.CreateDate!.ToISOString()):productEntity.CreateDate;
        productEntity.ModifyDate = string.IsNullOrEmpty(productDto.ModifyDate) ? DateTime.UtcNow : productDto.ModifyDate!.ToISOString();
    }
}