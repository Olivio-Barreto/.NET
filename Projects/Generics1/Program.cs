using Generics1.Entities;

namespace Generics1;

public class Program
{
    static void Main(string[] args)
    {
        var p = new PrintService();
        
        p.AddValue(2);
        p.AddValue(1);

        p.First();
        
        p.Print();
    }
}