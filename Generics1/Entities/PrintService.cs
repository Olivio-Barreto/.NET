namespace Generics1.Entities;

public class PrintService
{
    private int[] _values = new int[10];
    private int _count = 0;

    public void AddValue(int value)
    {
        if (_count == 10)
        {
            throw new InvalidOperationException("Print is full");
        }
        _values[_count] = value;
        _count++;
    }

    public int First()
    {
        return _values[0];
    }
}