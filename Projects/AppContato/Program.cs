using AppContato.Entities;
using AppContato.Interfaces;
using AppContato.Repositories;
using AppContato.Services;

namespace AppContato;

public class Program
{
    static void Main(string[] args)
    {
        IAppContatoRepository dependency = new AppContatoRepository();
        var appContato = new AppContatoService(dependency);

        var contato = new Contato("####", "010203");

        appContato.AddContato(contato);
        appContato.AddContato(new Contato("olivio", "000000000"));
        appContato.AddContato(new Contato("Barreto", "12345"));

        appContato.ProcurarContato("barreto");

        appContato.ListarContatos();

        appContato.ExcluirContato(contato);

        appContato.ListarContatos();
    }
}