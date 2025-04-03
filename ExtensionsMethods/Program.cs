using System.Globalization;
using ExtensionsMethods.Extensions;

namespace ExtensionsMethods;

public class Program
{
    private static void Main(string[] args)
    {
        string s1 = "Ola mundo!";

        Console.WriteLine(s1.Cut(1));
    }
}
