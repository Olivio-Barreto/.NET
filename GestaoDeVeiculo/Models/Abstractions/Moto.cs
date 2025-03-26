namespace GestaoDeVeiculo.Models.Abstractions;

public class Moto : Veiculo
{
    public double Cilindrada { get; set; }

    public override decimal CalcularAluguel(int dias)
    {
        return Diaria * dias;
    }
}