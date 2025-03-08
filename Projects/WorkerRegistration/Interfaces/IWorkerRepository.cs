using WorkerRegistration.Entities;

namespace WorkerRegistration.Interfaces;

public interface IWorkerRepository
{
    Task<bool> AddAsync(Worker worker);
    Task<bool> RemoveAsync(Worker worker);
    Task<bool> ContainsAsync(Worker worker);
    Task<Worker?> FindAsync(Worker worker);
    Task<Worker?> FindByIdAsync(Guid id);
    Task PrintAllAsync();
}