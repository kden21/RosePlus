using RosePlus.AppServices.Repositories;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

public class AttributeValueRepository : IAttributeValueRepository
{
    private readonly IRepository<AttributeValueEntity> _repository;

    public AttributeValueRepository(IRepository<AttributeValueEntity> repository)
    {
        _repository = repository;
    }

    public Task<AttributeValueEntity> GetAttributeValueById(int attributeValueId, CancellationToken cancellationToken)
    {
        return _repository.GetEntityById(attributeValueId, cancellationToken);
    }

    public Task<List<AttributeValueEntity>> GetAttributeValues(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAttributeValue(AttributeValueEntity attributeValueEntity, CancellationToken cancellationToken)
    {
        return _repository.AddEntity(attributeValueEntity, cancellationToken);
    }

    public async Task DeleteAttributeValue(int attributeValueId, CancellationToken cancellationToken)
    {
        await _repository.DeleteEntity(attributeValueId, cancellationToken);
    }

    public async Task UpdateAttributeValue(AttributeValueEntity attributeValueEntity, CancellationToken cancellationToken)
    {
        await _repository.UpdateEntity(attributeValueEntity, cancellationToken);
    }
}