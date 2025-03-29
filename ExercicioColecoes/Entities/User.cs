namespace ExercicioColecoes.Entities;

public class User(string name, int id)
{
    public int Id { get; init; } = id;
    public string Name { get; set; } = name;
}
