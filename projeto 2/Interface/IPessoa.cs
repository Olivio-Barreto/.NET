namespace projeto_2.Services;

public interface IPessoa
{
    void Falar(string message);
    string FalarNome();
    void Andar(int n);
    string ShowDetails();
}