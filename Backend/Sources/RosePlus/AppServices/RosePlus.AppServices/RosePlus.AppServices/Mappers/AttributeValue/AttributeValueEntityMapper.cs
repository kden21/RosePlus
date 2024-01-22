using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.AttributeValue;

public static class AttributeValueEntityMapper
{
    public static void FillAttributeValueEntity(this AttributeValueEntity attributeValueEntity, AttributeValueDto attributeValueDto)
    {
        attributeValueEntity.Id = attributeValueDto.Id;
        attributeValueEntity.Value = attributeValueDto.Value;
        attributeValueEntity.AttributeId = attributeValueDto.AttributeId;
        attributeValueEntity.ProductId = attributeValueDto.ProductId;
    }
}