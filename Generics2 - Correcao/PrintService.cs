namespace Generics2;

public class PrintService<T>
{
    private T[] _values = new T[10];
    private int _count = 0;

    public void AddValue(T item)
    {
        if (_count == 10)
        {
            throw new InvalidOperationException("PrintService is full!");
        }
        _values[_count] = item;
        _count++;
    }

    public T First()
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
        }
        if (_count > 0)
        {
            Console.Write(_values[_count - 1]);
        }
        Console.Write("]");
    }
}