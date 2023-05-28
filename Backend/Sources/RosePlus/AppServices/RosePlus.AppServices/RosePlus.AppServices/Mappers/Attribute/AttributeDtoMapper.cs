using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Attribute;

public static class AttributeDtoMapper
{
    public static void FillAttributeValueDto(this AttributeDto attributeDto, AttributeEntity attributeEntity)
    {
        attributeDto.Id = attributeEntity.Id;
        attributeDto.Name = attributeEntity.Name;
    }
}