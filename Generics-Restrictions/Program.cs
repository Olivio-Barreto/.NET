using Generics_Restrictions.Entities;
using Generics_Restrictions.Services;

namespace Generics_Restrictions;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("ENTER NUMBER OF PRODUCTS: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] vect = Console.ReadLine().Split(",");

            string name = vect[0];
            double price = double.Parse(vect[1]);

            list.Add(new Product(name, price));
        }

        var calculator = new CalculationService();

        var max = calculator.Max(list);

        Console.WriteLine($"Max: {max}");
    }
}