// See https://aka.ms/new-console-template for more information
using projeto.Classes;

// Console.WriteLine("Hello, World!");

// Console.WriteLine("Teste Pessoa Fisica: ");

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEnPf = new Endereco();

// novaPf.nome = "Jonatas";
// novaPf.cpf = "123123123";
// novaPf.rendimento = 5000;
// novaPf.dataNasc = new DateTime(2010,02,02);

// novoEnPf.logadouro = "poeta";
// novoEnPf.numero = 40;
// novoEnPf.complemento = "apt 202";
// novoEnPf.endComercial = false;

// novaPf.endereco = novoEnPf;

// Console.WriteLine("Dados: "+ novaPf.nome, novaPf.cpf);
// Console.WriteLine(@$"
//     Dados: {novaPf.nome} 
//     CPF: {novaPf.cpf} 
//     Rendimento: {novaPf.rendimento}
//     Data Nascimento: {novaPf.dataNasc}
//     Endereço: {novaPf.endereco.logadouro}{novaPf.endereco.numero}
//     ");


// DateTime data = new DateTime(2010,02,02);
// Console.WriteLine(novaPf.validarDataNasc(data));

// Console.WriteLine(novaPf.validarDataNasc("02-02-1992"));


// float impostoPagar = novaPf.CalcularImposto(1200);
// Console.WriteLine(novaPf.CalcularImposto(5000).ToString("C"));

Console.WriteLine("Teste Pessoa Jurídica: ");

PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(5000.50f).ToString("C"));

novaPj.cnpj = "21.390.426/0001-79" ;
string cnpj = "21390426000179";

Console.WriteLine(novaPj.ValidarCnpj(novaPj.cnpj));
Console.WriteLine(novaPj.ValidarCnpj(cnpj));