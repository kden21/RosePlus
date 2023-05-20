using RosePlus.AppServices.Mappers.ExtensionMethods;
using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Product;

public static class ProductEntityMapper
{
    public static ProductEntity MapProductEntity(this ProductDto productDto)
    {
        ProductEntity productEntity = new ProductEntity();
        productEntity.Id = productDto.Id;
        productEntity.ModifyDate = productDto.ModifyDate.FromString();
        productEntity.CreateDate = productDto.CreateDate.FromString();
        productEntity.Name = productDto.Name;
        productEntity.Description = productDto.Description;
        productEntity.Price = productDto.Price;
        productEntity.Count = productDto.Count;
        productEntity.CategoryId = productDto.CategoryId;

        return productEntity;
    }
}