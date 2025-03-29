namespace ExercicioColecoes.Entities;

public class PortalCourse
{
    public string Name { get; set; } = null!;
    public HashSet<User> Users { get; set; } = null!;
}
