
using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Entities;

public abstract class AbstractShape : IShape
{
    public Color Color { get; set; }
    public abstract double Area();
}
