using TreinandoHashSet.Entities;

namespace TreinandoHashSet.Service;

public class UsuariosDb
{
    public List<Usuario> Usuarios { get; set; } = null!;
    public HashSet<Usuario> UsuariosExcluidos { get; set; } = null!;
}