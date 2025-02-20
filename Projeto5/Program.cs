using Projeto5.Entities;

var motor = new Motor("Flex", 140);

var carro = new Carro("####", motor);

var pessoa1 = new Pessoa("####", 00);
var pessoa2 = new Pessoa("@@@@", 01, carro);

carro.Ligar();
carro.Desligar();