namespace SpaceCounter;

public static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(SpaceCounter("Ola meu mundo"));
    }

    private static int SpaceCounter(string message)
    {
        int countSpaces = 0;
        foreach (var t in message.Where(t => t == ' '))
        {
            countSpaces++;
        }

        return countSpaces;
    }
}
