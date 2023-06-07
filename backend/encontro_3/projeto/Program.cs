// See https://aka.ms/new-console-template for more information
using projeto.Classes;

// Console.WriteLine("Hello, World!");

Console.WriteLine("Teste Pessoa Fisica: ");

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Jonatas";
novaPf.cpf = "123123123";

Console.WriteLine("Dados: "+ novaPf.nome, novaPf.cpf);
Console.WriteLine($"Dados: {novaPf.nome} cpf:{novaPf.cpf}");



float impostoPagar = novaPf.CalcularImposto(1200);
Console.WriteLine(novaPf.CalcularImposto(5000).ToString("C"));

Console.WriteLine("Teste Pessoa Jurídica: ");
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(5000.50f).ToString("C"));