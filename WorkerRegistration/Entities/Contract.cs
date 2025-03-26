namespace WorkerRegistration.Entities;

public class Contract
{
    public decimal ValuePerHour { get; set; }
    public DateTime DateStarted { get; set; }
    public DateTime EndDate { get; set; }

    public Contract()
    {
    }

    public Contract(decimal valuePerHour, DateTime dateStarted, DateTime endDate)
    {
        ValuePerHour = valuePerHour;
        DateStarted = dateStarted;
        EndDate = endDate;
    }
}