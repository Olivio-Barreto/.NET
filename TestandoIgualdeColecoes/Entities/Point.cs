namespace TestandoIgualdeColecoes.Entities;

public struct Point(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
}