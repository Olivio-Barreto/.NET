using System;

namespace TestandoIgualdeColecoes
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Fulano");
            set.Add("Ciclano");

            // verificando elementos se GetHashCode e Equals são implementados no tipo da coleção
            Console.WriteLine(set.Contains("Fulano"));
        }
    }
}

