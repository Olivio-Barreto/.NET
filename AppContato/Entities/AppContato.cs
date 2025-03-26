using AppContato.Interfaces;

namespace AppContato.Entities;

public abstract class AppContato : IAppContatoService
{
    protected string? NomeAdmin { get; set; }
    protected string? EmailAdmin { get; set; }
    protected string? MeuNumero { get; set; }
    
    protected AppContato()
    {
    }

    protected AppContato(string nomeAdmin, string emailAdmin, string meuNumero)
    {
        NomeAdmin = nomeAdmin;
        EmailAdmin = emailAdmin;
        MeuNumero = meuNumero;
    }

    public abstract void SetNomeAdmin(string nome);

    public abstract void SetEmailAdmin(string email);

    public abstract void SetMeuNumero(string numero);
    
    public abstract bool ExcluirContato(Contato contato);

    public abstract bool AddContato(Contato contato);

    public abstract bool ProcurarContato(string info);

    public abstract void ListarContatos();
}