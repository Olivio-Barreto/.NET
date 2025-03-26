namespace Projeto5.Entities;

public class Motor
{
    public string TipoCombustivel { get; private set; }
    public double Potencia { get; private set; }

    public Motor(string tipoComb, double potencia)
    {
        TipoCombustivel = tipoComb;
        Potencia = potencia;
    }
}