using AppContato.Entities;
using AppContato.Interfaces;

namespace AppContato.Repositories;

public sealed class AppContatoRepository : IAppContatoRepository
{
    private List<Contato> _contatosDb = new List<Contato>();
    
    public bool Remove(Contato contato)
    {
        _contatosDb.Remove(contato);
        if (!_contatosDb.Contains(contato))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Add(Contato contato)
    {
        _contatosDb.Add(contato);
        if (_contatosDb.Contains(contato))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Source(string info)
    {
        var answer = _contatosDb.Any(x =>
            x.Nome != null && x.Nome.Equals(info, StringComparison.OrdinalIgnoreCase) ||
            x.Telefone != null && x.Telefone.Equals(info));

        if (answer == true)
        {
            Console.WriteLine(_contatosDb.Find(x =>
                x.Nome != null && x.Nome.Equals(info, StringComparison.OrdinalIgnoreCase) ||
                x.Telefone != null && x.Telefone.Equals(info)));
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public void ListAll()
    {
        foreach (var item in _contatosDb)
        {
            Console.WriteLine(item);
        }
    }
}