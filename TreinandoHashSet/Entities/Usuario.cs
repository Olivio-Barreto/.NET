namespace TreinandoHashSet.Entities;

public abstract class Usuario
{
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Senha { get; set; } = null!;

    public abstract void SetNome(string nome);

    public abstract void SetEmail(string email);

    public abstract void SetSenha(string senha);

    public abstract void UpdateNome(string nome);

    public abstract void UpdateEmail(string email);

    public abstract void UpdateSenha(string senha);
}