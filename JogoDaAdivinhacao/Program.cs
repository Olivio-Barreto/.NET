namespace JogoDaAdivinhacao;

public static class Program
{
    static void Main(string[] args)
    {
        int num = Random.Shared.Next(1, 100);
        int count = 0;

        while (true)
        {
            Console.Write("Digite o numero: ");
            var numUser = int.Parse(Console.ReadLine()!);

            if (numUser == num) break;

            Console.WriteLine(numUser > num ? "É menor" : "É maior");

            count++;
        }

        Console.WriteLine($"Você acertou com {count} tentativas. O número foi {num}");
    }
}