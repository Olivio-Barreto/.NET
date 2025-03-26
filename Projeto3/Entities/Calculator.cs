namespace Projeto3.Entities;

public class Calculator
{
    public double Somar( params double[] n)
    {
        double sum = 0.0;
        foreach(var item in n)
        {
            sum += item;
        }
        return sum;
    }

    public double Divisao(double n1, double n2)
    {
        return n1 / n2;
    }

    public double Subtrair(double n1, double n2)
    {
        return n1 - n2;
    }

    public double Multiplicar(double n1, double n2)
    {
        return n1 * n2;
    }

    public double Exponencial(double n1, double exponencial)
    {
        return Math.Pow(n1, exponencial);
    }

    public double Resto(double n1, double n2)
    {
        return n1 % n2;
    }
}