using System.ComponentModel.DataAnnotations;

namespace WorkerRegistration.Entities;

public class Employment
{
    [MaxLength(50)]
    public string? Name { get; set; }

    [MaxLength(50)]
    public string? EmploymentFunction { get; set; }
    public Contract? Contract { get; set; }

    public Employment()
    {
    }

    public Employment(string name, string employmentFunction, Contract contract)
    {
        Name = name;
        EmploymentFunction = employmentFunction;
        Contract = contract;
    }
}