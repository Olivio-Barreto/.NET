using Projeto.Entities;
using Projeto.Services;

int nota1 = 1;
int nota2 = 2;
int nota3 = 3;

var notas = new Notas(nota1, nota2, nota3);

var estudante = new Estudante("Olivio", 17, "olivio@gmail.com", "olivio", notas);

estudante.AddEstudante(estudante);

var injecao = new Authenticator();

var estudanteServices = new EstudanteServices(injecao);

Console.WriteLine(estudanteServices.Login(estudante));