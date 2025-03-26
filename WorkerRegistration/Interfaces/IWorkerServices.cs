using WorkerRegistration.Entities;

namespace WorkerRegistration.Interfaces;

public interface IWorkerServices
{
    Task<bool> AddWorkerAsync(Worker worker);
    Task<bool> RemoveWorkerAsync(Worker worker);
    Task<bool> ContainsWorkerAsync(Worker worker);
    Task<Worker> FindWorkerAsync(Worker worker);
    Task<Worker?> FindWorkerByIdAsync(Guid id);
    Task PrintAllAsync();
    string ShowDetails();
}