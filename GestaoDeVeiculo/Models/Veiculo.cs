namespace GestaoDeVeiculo.Models;

public abstract class Veiculo
{
    public string Placa { get; private set; } = null!;
    public string Modelo { get; private set; } = null!;
    public int Ano { get; private set; }
    public decimal Diaria { get; set; }

    public abstract decimal CalcularAluguel(int dias);
}