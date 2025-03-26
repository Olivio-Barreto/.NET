using AppContato.Entities;

namespace AppContato.Interfaces;

public interface IAppContatoService
{
    void SetNomeAdmin(string nome);
    void SetEmailAdmin(string email);
    void SetMeuNumero(string numero);
    bool ExcluirContato(Contato contato);
    bool AddContato(Contato contato);
    bool ProcurarContato(string info);
    void ListarContatos();
}