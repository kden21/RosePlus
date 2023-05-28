using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Mappers.Attribute;

public static class AttributeEntityMapper
{
    public static void FillAttributeEntity(this AttributeEntity attributeEntity, AttributeDto attributeDto)
    {
        attributeEntity.Id = attributeDto.Id;
        attributeEntity.Name = attributeDto.Name;
    }
}