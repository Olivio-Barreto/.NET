
using projeto_2.Entities;

namespace projeto_2.Services;

public class PessoaFisica : Pessoa
{
    
    private string CPF { get; set; }

    public PessoaFisica()
    {
    }
    
    public PessoaFisica(string cpf)
    {
        CPF = cpf;
    }
    
    
    public override void Falar(string message)
    {
        Console.WriteLine(message);
    }

    public override string FalarNome()
    {
        return $"Meu nome é {Nome}";
    }

    public override void Andar(int n)
    {
        Console.WriteLine($"{Nome} andou {n} passos!");
    }

    public override string ShowDetails()
    {
        return $"Nome: {Nome}, Idade: {Idade}, Estado Civil: {EstadoCivil}";
    }
}