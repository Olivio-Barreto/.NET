namespace HashSet_and_SortedSet;

public class Program
{
    static void Main(string[] args)
    {
        // coolection expression
        SortedSet<int> a = [1, 2, 3, 4];
        SortedSet<int> b = [5, 6, 7, 8];

        // union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
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