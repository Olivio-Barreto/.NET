
using Projeto3.Entities;

public class Program
{
    static void Main(string[] args)
    {
        var operacoes = new Calculator();

        Console.WriteLine(operacoes.Somar(1, 2));
        Console.WriteLine(operacoes.Subtrair(3, 1));
        Console.WriteLine(operacoes.Divisao(2, 1));
        Console.WriteLine(operacoes.Multiplicar(1, 5));
        Console.WriteLine(operacoes.Exponencial(1, 4));
        Console.WriteLine(operacoes.Resto(5, 2));
    }
}