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
        if (_values.Length == 0)
        {
            throw new InvalidOperationException("The Array has no elements!");
        }
        return _values[0];
    }

    public void Print()
    {
        Console.Write("[");
        for (int i = 0; i < _count - 1; i++)
        {
            Console.Write($"{_values[i]}, ");
            if (_values[_count - 1] > 0)
            {
                Console.Write(_values[_count - 1]);
            }
        }
        Console.Write("]");
    }
}