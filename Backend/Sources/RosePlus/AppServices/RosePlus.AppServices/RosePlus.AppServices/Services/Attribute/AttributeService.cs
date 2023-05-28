using RosePlus.AppServices.Mappers.Attribute;
using RosePlus.AppServices.Repositories;
using RosePlus.Contracts.Dto;
using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Services.Attribute;

/// <inheritdoc />
public class AttributeService : IAttributeService
{
    private readonly IAttributeRepository _attributeRepository;

    public AttributeService(IAttributeRepository attributeRepository)
    {
        _attributeRepository = attributeRepository;
    }

    /// <inheritdoc />
    public async Task<AttributeDto> GetAttributeByIdAsync(int attributeId, CancellationToken cancellationToken)
    {
        AttributeEntity attributeEntity = await _attributeRepository.GetAttributeById(attributeId, cancellationToken);
        AttributeDto attributeDto = new AttributeDto();
        attributeDto.FillAttributeDto(attributeEntity);
        return attributeDto;
    }

    /// <inheritdoc />
    public Task<IEnumerable<AttributeDto>> GetAttributesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<int> AddAttributeAsync(AttributeDto attributeDto, CancellationToken cancellationToken)
    {
        AttributeEntity attributeEntity = new AttributeEntity();
        attributeEntity.FillAttributeEntity(attributeDto);
        return _attributeRepository.AddAttribute(attributeEntity, cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteAttributeAsync(int attributeId, CancellationToken cancellationToken)
    {
        await _attributeRepository.DeleteAttribute(attributeId, cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateAttributeAsync(AttributeDto attributeDto, CancellationToken cancellationToken)
    {
        AttributeEntity attributeEntity = new AttributeEntity();
        attributeEntity.FillAttributeEntity(attributeDto);
        await _attributeRepository.UpdateAttribute(attributeEntity, cancellationToken);
    }
}