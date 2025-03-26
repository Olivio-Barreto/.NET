using WorkerRegistration.Entities;
using WorkerRegistration.Interfaces;

namespace WorkerRegistration.Services;

public class WorkerService : Worker
{
    private IWorkerRepository _workerRepository;

    public WorkerService(IWorkerRepository workerRepository)
    {
        _workerRepository = workerRepository;
    }

    public override async Task<bool> AddWorkerAsync(Worker worker)
    {
        return await _workerRepository.AddAsync(worker);
    }

    public override async Task<bool> RemoveWorkerAsync(Worker worker)
    {
        return await _workerRepository.RemoveAsync(worker);
    }

    public override async Task<bool> ContainsWorkerAsync(Worker worker)
    {
        return await _workerRepository.ContainsAsync(worker);
    }

    public override async Task<Worker> FindWorkerAsync(Worker worker)
    {
        return await _workerRepository.FindAsync(worker);
    }

    public override async Task<Worker?> FindWorkerByIdAsync(Guid id)
    {
        return await _workerRepository.FindByIdAsync(id);
    }

    public override async Task PrintAllAsync()
    {
        await _workerRepository.PrintAllAsync();
    }

    public override string ShowDetails()
    {
        return base.ToString();
    }
}