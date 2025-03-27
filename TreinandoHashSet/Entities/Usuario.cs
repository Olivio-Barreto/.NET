namespace TreinandoHashSet.Entities;

public abstract class Usuario
{
    protected string Nome { get; set; } = null!;
    protected string Email { get; set; } = null!;
    protected string Senha { get; set; } = null!;

    public abstract void SetNome(string nome);

    public abstract void SetEmail(string email);

    public abstract void SetSenha(string senha);

    public abstract void UpdateNome(string nome);

    public abstract void UpdateEmail(string email);

    public abstract void UpdateSenha(string senha);
}