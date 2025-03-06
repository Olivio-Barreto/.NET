using AppContato.Entities;
using AppContato.Interfaces;

namespace AppContato.Services;

public class AppContatoService : AppContato.Entities.AppContato
{
    private IAppContatoRepository _contatoDb;

    public AppContatoService(IAppContatoRepository contatoDb)
    {
        _contatoDb = contatoDb;
    }

    public AppContatoService(string nomeAdmin, string emailAdmin, string meuNumero, IAppContatoRepository contatoDb)
        : this(contatoDb)
    {
        NomeAdmin = nomeAdmin;
        EmailAdmin = emailAdmin;
        MeuNumero = meuNumero;
    }
    
    public override void SetNomeAdmin(string nome)
    {
        NomeAdmin = nome;
    }

    public override void SetEmailAdmin(string email)
    {
        EmailAdmin = email;
    }

    public override void SetMeuNumero(string numero)
    {
        MeuNumero = numero;
    }

    public override bool ExcluirContato(Contato contato)
    {
        return _contatoDb.Remove(contato);
    }

    public override bool AddContato(Contato contato)
    {
        return _contatoDb.Add(contato);
    }

    public override bool ProcurarContato(string info)
    {
        return _contatoDb.Source(info);
    }

    public override void ListarContatos() => _contatoDb.ListAll();
}