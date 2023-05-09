using RosePlus.AppServices.Repositories;
using RosePlus.Domain.Entities;

namespace RosePlus.DataAccess.Context.Repositories;

public class LoggerRepository : ILoggerDbRepository
{
    private readonly IRepository<LogEntity> _repository;

    public LoggerRepository(IRepository<LogEntity> repository)
    {
        _repository = repository;
    }
    
    public Task<int> AddLog(LogEntity logEntity, CancellationToken cancellationToken)
    {
        return _repository.AddEntity(logEntity, cancellationToken);
    }
}