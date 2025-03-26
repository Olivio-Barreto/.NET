using Projeto.Entities;
using Projeto.Interfaces;

namespace Projeto.Services;

public class EstudanteServices
{
    private ILoginService _loginService;

    public EstudanteServices(ILoginService loginService)
    {
        _loginService = loginService;
    }

    public bool Login(Estudante estudante)
    {
        var login = _loginService.Validacao(estudante.Email, estudante.Senha);
        
        return login;
    }
}
