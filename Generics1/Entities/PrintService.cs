namespace Generics1.Entities;

public class PrintService
{
    private int[] _values = new int[10];
    private int _count = 0;

    public void AddValue(int value)
    {
        _values[_count] = value;
        _count++;
    }
}