using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.AttributeValue;

public static class AttributeValueDtoMapper
{
    public static void FillAttributeValueDto(this AttributeValueDto attributeValueDto, AttributeValueEntity attributeValueEntity)
    {
        attributeValueDto.Id = attributeValueEntity.Id;
        attributeValueDto.Value = attributeValueEntity.Value;
        attributeValueDto.AttributeId = attributeValueEntity.AttributeId;
        attributeValueDto.ProductId = attributeValueEntity.ProductId;
    }
}