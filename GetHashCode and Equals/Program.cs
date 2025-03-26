using GetHashCode_and_Equals.Entities;

namespace GetHashCode_and_Equals;

public class Program
{
    static void Main(string[] args)
    {
        // resposta não é direta
        // mais rápido
        string a = "Olivio";
        string b = "Olivio";

        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());

        // resposta é direta
        // mais lento
        Console.WriteLine(a.Equals(b));

        // teste
        Client c1 = new Client()
        {
            Name = "Olivio",
            Email = "a"
        };
        Client c2 = new Client()
        {
            Name = "Eu",
            Email = "a"
        };

        Console.WriteLine(c1.Equals(c2));
        Console.WriteLine(c1.GetHashCode());
        Console.WriteLine(c2.GetHashCode());
    }
}
