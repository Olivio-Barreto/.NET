using System;
using System.Collections;

namespace Projeto5.Entities;

public class Pessoa
{
    public string Nome {get; private set;} = string.Empty;
    public int Idade {get;private set;}
    public Carro? Carro {get;private set;}

    public Pessoa()
    {
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Pessoa(string nome, int idade, Carro carro) : this(nome, idade)
    {
        Carro = carro;
    }


    public override string ToString()
    {
        if(Carro != null)
        {
            return $"Nome: {Nome}, Idade: {Idade}, Carro: {Carro}";
        }
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}
