using Projeto.Services;

namespace Projeto.Entities;

public class Estudante
{
    #region  Props
    public string? Nome { get; private set; }
    public int Idade { get; private set; }
    public string? Email { get; private set; }
    public string? Senha { get; private set; }
    public Notas? Notas { get; private set; }
    
    #endregion

    #region Constructor

    public Estudante(string? nome, int idade, string? email, string? senha, Notas? notas)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
        Senha = senha;
        Notas = notas;
    }

    #endregion
    

    public void AddEstudante(Estudante estudante)
    {
        EstudanteRepository.EstudantesDb.Add(estudante);
    }
}