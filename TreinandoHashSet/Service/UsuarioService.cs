using TreinandoHashSet.Entities;

namespace TreinandoHashSet.Service;

public class UsuarioService(UsuariosDb context) : Usuario
{
    private UsuariosDb _context = context;

    public override void SetNome(string nome)
    {
        Nome = nome;
    }

    public override void SetEmail(string email)
    {
        Email = email;
    }

    public override void SetSenha(string senha)
    {
        Senha = senha;
    }

    public override void UpdateNome(string nome)
    {
        Nome = nome;
    }

    public override void UpdateEmail(string email)
    {
        Email = email;
    }

    public override void UpdateSenha(string senha)
    {
        Senha = senha;
    }

    public void DeletarUsuario(Usuario? usuario)
    {
        var user = _context.Usuarios
            .Find(u => usuario != null && u.Email == usuario.Email && u.Senha == usuario.Senha)!;

        _context.UsuariosExcluidos.Add(user);

        _context.Usuarios.Remove(user);
    }
}