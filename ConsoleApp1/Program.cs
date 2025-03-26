using ConsoleApp1.Entities;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;

public class Program
{
    static void Main(string[] args)
    {
        IShape shape1 = new Circle(2.0)
        {
            Color = Color.Branco
        };
        IShape shape2 = new Retangle(2.0, 2.0) {Color = Color.Preto};

        
    }
}