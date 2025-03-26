namespace GestaoDeVeiculo.Models.Abstractions;

public class Carro : Veiculo
{
    public bool IsSedan { get; set; } = false;
    public bool IsSuv { get; set; } = false;
    public bool IsHatch { get; set; } = false;

    public override decimal CalcularAluguel(int dias)
    {
        return Diaria * dias;
    }
}