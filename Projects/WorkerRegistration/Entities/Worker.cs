using System.ComponentModel.DataAnnotations;
using WorkerRegistration.Interfaces;

namespace WorkerRegistration.Entities;

public abstract class Worker : IWorkerServices
{
    protected Guid Id { get; init; }

    [MaxLength(50)]
    protected string? Name { get; private set; }

    [MaxLength(50)]
    protected string? Surname { get; private set; }

    [MaxLength(50)]
    protected string? CpfCnpj { get; private set; }

    protected Employment? Employment { get; set; }

    protected Worker()
    {
        Id = Guid.NewGuid();
    }

    protected Worker(string name, string surname, string cpfCnpj, Employment employment) : this()
    {
        Name = name;
        Surname = surname;
        CpfCnpj = cpfCnpj;
        Employment = employment;
    }

    public abstract Task<bool> AddWorkerAsync(Worker worker);

    public abstract Task<bool> RemoveWorkerAsync(Worker worker);

    public abstract Task<bool> ContainsWorkerAsync(Worker worker);

    public abstract Task<Worker> FindWorkerAsync(Worker worker);

    public abstract Task<Worker?> FindWorkerByIdAsync(Guid id);

    public abstract Task PrintAllAsync();

    public abstract string ShowDetails();

    public override string ToString()
    {
        return $"Name: {Name}, \n" +
               $" Surname: {Surname}, \n" +
               $"CPF: {CpfCnpj}, \n\n" +
               $"Employment Name: {Employment.Name}, \n" +
               $"Employment Function: {Employment.EmploymentFunction}, \n\n" +
               $"Value per Hour: {Employment.Contract.ValuePerHour}, \n" +
               $"Date Started: {Employment.Contract.DateStarted}, \n" +
               $"End Date: {Employment.Contract.EndDate}, \n\n";
    }
}