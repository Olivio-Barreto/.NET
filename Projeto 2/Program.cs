using projeto_2.Services;

var p1 = new PessoaFisica("#########")
{
    Nome = "nome",
    Idade = 000,
    Emprego = "Não"
};

var pessoa1 = new PessoaService(p1);

Console.WriteLine(pessoa1.Apresentacao());