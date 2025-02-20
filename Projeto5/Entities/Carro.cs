using System;
using System.Runtime.ConstrainedExecution;
using Projeto5.Interfaces;

namespace Projeto5.Entities;

public class Carro : IVeiculo
{
    public string Modelo { get; set; } = string.Empty;

    public void Desligar()
    {
        Console.WriteLine("Carro Desligado!");
    }

    public void Ligar()
    {
        Console.WriteLine("Carro Ligado!");
    }
}
