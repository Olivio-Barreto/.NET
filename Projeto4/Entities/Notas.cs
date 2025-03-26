namespace Projeto.Entities;

public class Notas
{
    public int Nota1 { get; private set; }
    public int Nota2 { get; private set; }
    public int Nota3 { get; private set; }

    public Notas(int nota1, int nota2, int nota3)
    {
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    }
}