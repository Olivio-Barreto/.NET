using Teste_EFcore.Data;

public class Program
{
    static void Main(string[] args)
    {
        using (var context = new MyDbContext())
        {
            var purchase = new Purchase()
            {
                Id = 1,
                Product = "Bola",
                Price = 20
            };

            context.Purchases.Add(purchase);
            context.SaveChanges();
            
            //

            var p = context.Purchases.Where(p => p.Price > 20);
        }
    }
}


public class Purchase
{
    public int Id { get; set; }
    public string? Product { get; set; }
    public decimal Price { get; set; }
}