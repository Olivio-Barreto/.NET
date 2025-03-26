using System;
using TestandoIgualdeColecoes.Entities;

namespace TestandoIgualdeColecoes
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            /* Se o GetHashCode não estiver implementado no tipo:
             * Tipo Referência => Compara a referência dos objetos
             * Tipo Valor => Compara o valor dos atributos
            */

            HashSet<Product> collectionProducts = new HashSet<Product>();

            collectionProducts.Add(new Product("Celular", 2000));
            collectionProducts.Add(new Product("TV", 5000));

            HashSet<Point> collectionPoints = new HashSet<Point>();

            collectionPoints.Add(new Point(2, 4));
            collectionPoints.Add(new Point(3, 2));

            // executando com tipo referência
            Product product = new Product("TV", 5000);
            Console.WriteLine(collectionProducts.Contains(product));

            // executando com tipo valor
            Point point = new Point(2, 4);
            Console.WriteLine(collectionPoints.Contains(point));
        }
    }
}

