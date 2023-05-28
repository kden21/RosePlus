using RosePlus.Contracts.Dto;

namespace RosePlus.AppServices.Services.Attribute;

/// <inheritdoc />
public class AttributeService : IAttributeService
{
    /// <inheritdoc />
    public Task<AttributeDto> GetAttributeByIdAsync(int attributeId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<IEnumerable<AttributeDto>> GetAttributesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<int> AddAttributeAsync(AttributeDto attributeDto, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task DeleteAttributeAsync(int attributeId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task UpdateAttributeAsync(AttributeDto attributeDto, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}