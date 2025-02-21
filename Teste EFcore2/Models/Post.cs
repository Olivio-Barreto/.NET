namespace Teste_EFcore2.Models;

public class Post
{
    public string? Titulo { get; set; }
    public int Curtidas { get; set; }
    public List<string> Comentarios { get; set; } = new List<string>();
}