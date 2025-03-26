namespace Generics_Restrictions.Entities;

public class Product : IComparable
{
    private string? Name { get; set; }
    private double Price { get; set; }

    public Product(string? name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}";
    }

    public int CompareTo(object? obj)
    {
        if (!(obj is Product))
        {
            throw new ArgumentException("Object is not a Product!");
        }

        Product? other = obj as Product;
        return Price.CompareTo(other.Price);
    }
}