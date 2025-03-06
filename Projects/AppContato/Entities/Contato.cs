namespace AppContato.Entities;

public sealed class Contato
{
    public string? Nome { get; private set; }
    public string? Telefone { get; private set; }

    public Contato()
    {
    }

    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}";
    }
}