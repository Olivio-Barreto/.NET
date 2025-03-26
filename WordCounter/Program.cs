namespace Word_Counter;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();

        Console.WriteLine(WordCounter($"Meu nome é {nome}"));
    }

    static int WordCounter(string message)
    {
        int count = 0;
        string[] array = message.Split(' ');
        for (int i = 0; i < array.Length; i++)
        {
            count++;
        }

        return count;
    }
}