namespace ConsoleApp1.Entities;

public class Circle : AbstractShape
{
    public double Radius { get; private set; }

    public Circle()
    {
    }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}