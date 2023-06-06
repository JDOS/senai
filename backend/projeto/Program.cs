// See https://aka.ms/new-console-template for more information
using projeto.Classes;

// Console.WriteLine("Hello, World!");


PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Jonatas";
novaPf.cpf = "123123123";

Console.WriteLine("Dados: "+ novaPf.nome, novaPf.cpf);
Console.WriteLine($"Dados: {novaPf.nome} cpf:{novaPf.cpf}");
