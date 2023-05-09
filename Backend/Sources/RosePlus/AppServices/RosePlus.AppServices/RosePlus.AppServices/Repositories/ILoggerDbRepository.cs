using RosePlus.Domain.Entities;

namespace RosePlus.AppServices.Repositories;

/// <summary>
/// Репозитория логгирования в БД.
/// </summary>
public interface ILoggerDbRepository
{
    Task<int> AddLog(LogEntity logEntity ,CancellationToken cancellationToken);
}