using System.Diagnostics.CodeAnalysis;

namespace ExercicioColecoes.Entities;

public class Instructor(string name)
{
    public string Name { get; set; } = name;

    public List<PortalCourse> Courses { get; set; } = null!;

    public void AddCourse(params PortalCourse[] courses)
    {
        foreach (var item in courses)
        {
            Courses.Add(item);
        }
    }
}
