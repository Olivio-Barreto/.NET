using projeto_2.Services;

namespace projeto_2.Entities;

public abstract class Pessoa : IPessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string EstadoCivil { get; set; }
    public string Emprego { get; set; }


    public abstract void Falar(string message);

    public abstract string FalarNome();

    public abstract void Andar(int n);

    public abstract string ShowDetails();
}