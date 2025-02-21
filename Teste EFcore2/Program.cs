using Teste_EFcore2.Data;
using Teste_EFcore2.Models;

namespace Teste_EFcore2;

public class Program
{
    static void Main(string[] args)
    {
        using (var db = new MyDbContext())
        {
            var post = new Post()
            {
                Titulo = "Minha Foto",
                Curtidas = 40,
                Comentarios = { "bom", "Muito lindo" }
            };
            var curtidas = db.Posts.Where(x => x.Curtidas >= 0).ToList();
        }
    }
}