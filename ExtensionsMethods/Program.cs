using System.Globalization;
using ExtensionsMethods.Extensions;

namespace ExtensionsMethods;

public class Program
{
    private static void Main(string[] args)
    {
        var temp = new DateTime(2025, 04, 03, 07, 30, 00);

        Console.WriteLine(temp.ElapsedTime());
    }
}
