namespace HashSet_and_SortedSet;

public class Program
{
    static void Main(string[] args)
    {
        // coolection expression
        SortedSet<int> a = [1, 2, 3, 4];
        SortedSet<int> b = [4, 5, 6, 7, 8];

        // union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b); // C recebe elementos de A e B unidos
        PrintCollection(c);

        // intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b); // elementos que são iguais entre as coleções
        PrintCollection(d);

        // diffenrence
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b); // elementos de A com os de B excluídos
        PrintCollection(e);
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");
        }

        Console.WriteLine();
    }
}