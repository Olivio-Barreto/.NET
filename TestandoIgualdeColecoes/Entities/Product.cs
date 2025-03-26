namespace TestandoIgualdeColecoes.Entities;

public class Product(string name, decimal price)
{
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Price.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj is Product other && Name.Equals(other.Name) && Price.Equals(other.Price);
    }
}