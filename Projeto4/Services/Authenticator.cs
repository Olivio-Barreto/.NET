using Projeto.Interfaces;

namespace Projeto.Services;

public class Authenticator : ILoginService
{
    public bool Validacao(string? login, string? senha)
    {
        var answer = EstudanteRepository
            .EstudantesDb.Any(x => x.Email == login && x.Senha == senha);
        
        return answer;
    }
}