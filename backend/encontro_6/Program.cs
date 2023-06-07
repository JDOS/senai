// See https://aka.ms/new-console-template for more information
using projeto.Classes;


Console.WriteLine(@$"
=====================================
    BEM VINDO AO SISTEMA JDOS
    CADASTRO PESSOA FÍSCA E JURÍDICA
=====================================
");
Console.ForegroundColor = ConsoleColor.Yellow;
Utils.BarraCarregamento();

string? opcao = Console.ReadLine();

Console.ResetColor();
do{
Console.Clear();
Console.WriteLine(@$"
=====================================
                Opções
=====================================
1) Física
2) Jurídica
0) Exit
");





// if(opcao=="1"){
//     Console.WriteLine(opcao);
// }
// else if(opcao=="2"){
//     Console.WriteLine(opcao);
// }
// else if(opcao=="3"){
//     Console.WriteLine(opcao);
// }

switch(opcao){
    case "1":
    PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnPf = new Endereco();

novaPf.nome = "Jonatas";
novaPf.cpf = "123123123";
novaPf.rendimento = 5000;
novaPf.dataNasc = new DateTime(2010,02,02);

novoEnPf.logadouro = "poeta";
novoEnPf.numero = 40;
novoEnPf.complemento = "apt 202";
novoEnPf.endComercial = false;

novaPf.endereco = novoEnPf;

Console.WriteLine("Dados: "+ novaPf.nome, novaPf.cpf);
Console.WriteLine(@$"
    Dados: {novaPf.nome} 
    CPF: {novaPf.cpf} 
    Rendimento: {novaPf.rendimento}
    Data Nascimento: {novaPf.dataNasc}
    Endereço: {novaPf.endereco.logadouro}{novaPf.endereco.numero}
    ");

    Thread.Sleep(2000);
        break;
    case "2":

     PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(5000.50f).ToString("C"));

novaPj.cnpj = "21.390.426/0001-79" ;
string cnpj = "21390426000179";

Console.WriteLine(novaPj.ValidarCnpj(novaPj.cnpj));
Console.WriteLine(novaPj.ValidarCnpj(cnpj));
Thread.Sleep(2000);
        break;
    case "0":
        break;
    default:
        Console.WriteLine($"Opção não existente!");
        Thread.Sleep(2000);
        break;
}

}while(opcao != "0");
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

// Console.WriteLine("Teste Pessoa Jurídica: ");

// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(5000.50f).ToString("C"));

// novaPj.cnpj = "21.390.426/0001-79" ;
// string cnpj = "21390426000179";

// Console.WriteLine(novaPj.ValidarCnpj(novaPj.cnpj));
// Console.WriteLine(novaPj.ValidarCnpj(cnpj));