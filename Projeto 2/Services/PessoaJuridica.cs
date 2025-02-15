
using projeto_2.Entities;

namespace projeto_2.Services;

public class PessoaJuridica : Pessoa
{
    private string NomeEmpresa { get; set; }
    private int NumeroFuncionario { get; set; }
    private decimal SaldoEmpresa { get; set; }
    private string CNPJ { get; set; }


    public PessoaJuridica(string nomeEmpresa, int numeroFuncionario, decimal saldoEmpresa, string cnpj)
    {
        NomeEmpresa = nomeEmpresa;
        NumeroFuncionario = numeroFuncionario;
        SaldoEmpresa = saldoEmpresa;
        CNPJ = cnpj;
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
        Console.WriteLine($"{Nome} andou {n} passos");
    }

    public override string ShowDetails()
    {
        return $"Nome: {Nome}\n, Idade: {Idade},\n" +
               $"Estado Civil: {EstadoCivil}\n" +
               $"Numero de Funcionarios {NumeroFuncionario}\n" +
               $"Nome da Empresa: {NomeEmpresa}\n" +
               $"CNPJ: {CNPJ}";
    }
}