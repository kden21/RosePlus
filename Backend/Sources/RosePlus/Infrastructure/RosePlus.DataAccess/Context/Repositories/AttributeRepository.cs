using RosePlus.AppServices.Repositories;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

public class AttributeRepository : IAttributeRepository
{
    private readonly IRepository<AttributeEntity> _repository;

    public AttributeRepository(IRepository<AttributeEntity> repository)
    {
        _repository = repository;
    }

    public Task<AttributeEntity> GetAttributeById(int attributeId, CancellationToken cancellationToken)
    {
        return _repository.GetEntityById(attributeId, cancellationToken);
    }

    public Task<List<AttributeEntity>> GetAttributes(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAttribute(AttributeEntity attributeEntity, CancellationToken cancellationToken)
    {
        return _repository.AddEntity(attributeEntity, cancellationToken);
    }

    public async Task DeleteAttribute(int attributeId, CancellationToken cancellationToken)
    {
        await _repository.DeleteEntity(attributeId, cancellationToken);
    }

    public async Task UpdateAttribute(AttributeEntity attributeEntity, CancellationToken cancellationToken)
    {
        await _repository.UpdateEntity(attributeEntity, cancellationToken);
    }
}