namespace GestaoDeVeiculo.Models.Abstractions;

public class Caminhao : Veiculo
{
    public double Carga { get; set; }

    public override decimal CalcularAluguel(int dias)
    {
        return Diaria * dias;
    }
}