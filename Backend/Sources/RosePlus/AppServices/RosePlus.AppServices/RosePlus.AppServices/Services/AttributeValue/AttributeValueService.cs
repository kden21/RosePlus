using RosePlus.AppServices.Mappers.AttributeValue;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Services.AttributeValue;

/// <inheritdoc />
public class AttributeValueService : IAttributeValueService
{
    private readonly IAttributeValueRepository _attributeValueRepository;

    public AttributeValueService(IAttributeValueRepository attributeValueRepository)
    {
        _attributeValueRepository = attributeValueRepository;
    }

    /// <inheritdoc />
    public async Task<AttributeValueDto> GetAttributeValueByIdAsync(int attributeValueId, CancellationToken cancellationToken)
    {
        AttributeValueEntity attributeValueEntity = await _attributeValueRepository.GetAttributeValueById(attributeValueId, cancellationToken);
        AttributeValueDto attributeValueDto = new AttributeValueDto();
        attributeValueDto.FillAttributeValueDto(attributeValueEntity);
        return attributeValueDto;
    }

    /// <inheritdoc />
    public Task<IEnumerable<AttributeValueDto>> GetAttributeValuesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<int> AddAttributeValueAsync(AttributeValueDto attributeValueDto, CancellationToken cancellationToken)
    {
        AttributeValueEntity attributeValueEntity = new AttributeValueEntity();
        attributeValueEntity.FillAttributeValueEntity(attributeValueDto);
        return _attributeValueRepository.AddAttributeValue(attributeValueEntity, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteAttributeValueAsync(int attributeValueId, CancellationToken cancellationToken)
    {
        await _attributeValueRepository.DeleteAttributeValue(attributeValueId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateAttributeValueAsync(AttributeValueDto attributeValueDto, CancellationToken cancellationToken)
    {
        AttributeValueEntity attributeValueEntity = new AttributeValueEntity();
        attributeValueEntity.FillAttributeValueEntity(attributeValueDto);
        await _attributeValueRepository.UpdateAttributeValue(attributeValueEntity, cancellationToken);
    }
}