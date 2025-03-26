namespace Projeto.Interfaces;

public interface ILoginService
{
    bool Validacao(string login, string senha);
}