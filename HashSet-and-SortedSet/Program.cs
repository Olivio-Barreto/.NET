namespace HashSet_and_SortedSet;

public class Program
{
    static void Main(string[] args)
    {

    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.WriteLine(obj + " ");
        }

        Console.WriteLine();
    }
}