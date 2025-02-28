using AppContato.Entities;

namespace AppContato.Interfaces;

public interface IAppContatoRepository
{
    bool Remove(Contato contato);
    bool Add(Contato contato);
    bool Source(string info);
    void ListAll();
}