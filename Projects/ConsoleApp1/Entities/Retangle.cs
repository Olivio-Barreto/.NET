using System.Drawing;

namespace ConsoleApp1.Entities;

public class Retangle : AbstractShape
{
    private double Width { get; set; }
    private double Heigth { get; set; }
    
    public Retangle(double width, double heigth)
    {
        Width = width;
        Heigth = heigth;
    }

    public override double Area()
    {
        var answer = Width * Heigth;

        return answer;
    }
}