using Microsoft.EntityFrameworkCore;
using WorkerRegistration.Data;
using WorkerRegistration.Entities;
using WorkerRegistration.Interfaces;

namespace WorkerRegistration.Repositories;

public class WorkerRepository : IWorkerRepository
{
    private AppDbContext _dbContext;

    public WorkerRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> AddAsync(Worker worker)
    {
        try
        {
            await _dbContext.Workers.AddAsync(worker);
            return await _dbContext.SaveChangesAsync() > 0;
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("Error adding worker.", e);
        }
    }

    public async Task<bool> RemoveAsync(Worker worker)
    {
        try
        {
            _dbContext.Workers.Remove(worker);
            return await _dbContext.SaveChangesAsync() > 0;
        }
        catch (Exception e)
        {
            throw new InvalidOperationException("Error removing worker.", e);
        }
    }

    public async Task<bool> ContainsAsync(Worker worker)
    {
        try
        {
            return await _dbContext.Workers.ContainsAsync(worker);
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR -> {e.Message}.");
            return false;
        }
    }

    public async Task<Worker?> FindAsync(Worker worker)
    {
        try
        {
            return await _dbContext.Workers.FindAsync(worker);
        }
        catch (Exception e)
        {
            throw new KeyNotFoundException("Worker does not exist.", e);
        }
    }

    public async Task<Worker?> FindByIdAsync(Guid id)
    {
        try
        {
            return await _dbContext.Workers.FindAsync(id);
        }
        catch (Exception e)
        {
            throw new KeyNotFoundException($"User with ID {id} not found.", e);
        }
    }

    public async Task PrintAllAsync()
    {
        await foreach (var item in _dbContext.Workers)
        {
            Console.WriteLine(item);
        }
    }
}