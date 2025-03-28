namespace NumeroPrimo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SAIBA SE UM NÚMERO É PRIMO");
        Console.Write("Digite um número ");
        int num = int.Parse(Console.ReadLine()!);

        if (num < 2)
        {
            Console.WriteLine("Numeros menores que 2 não podem ser primos");
        }
        else
        {
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                Console.WriteLine(num % i == 0 ? "Não é primo!" : "É primo!");
            }
        }
    }
}