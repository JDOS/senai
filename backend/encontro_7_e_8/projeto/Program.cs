// See https://aka.ms/new-console-template for more information
using projeto.Classes;
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


string? opcao;
string? opcaoPj;

Utils.BarraCarregamento();
Console.Clear();

Console.WriteLine(@$"
            =================================================
            |      Bem Vindo ao Sistema de Cadastro de      |
            |            Pessoa Física e Jurídica           |
            =================================================
");
Thread.Sleep(2000);



do
{
    Console.Clear();
    Console.WriteLine(@$"
            =================================================
            |        Digite uma das opções abaixo           |
            |        e tecle Enter para continuar           |
            =================================================
            |                                               |
            |             1 - Pessoa Jurídica               |
            |             2 - Pessoa Física                 |
            |                                               |
            |             0 - Sair                          |
            =================================================
");

    opcao = Console.ReadLine();
    //Console.WriteLine($"Você digitou: {opcao}");

    switch (opcao)
    {
        case "1":

            do
            {

                Console.Clear();
                Console.WriteLine(@$"
            =================================================
            |   Digite o número de uma das opções abaixo:   |
            =================================================
            |                                               |
            |        1 - Cadastrar Pessoa Jurídica          |
            |        2 - Listar Pessoa Jurídica             |
            |                                               |
            |        0 - Voltar ao menu anterior            |
            =================================================
");

                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":

                        PessoaJuridica novaPJ = new PessoaJuridica();
                        Endereco novoEndPJ = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite o CNPJ da empresa");
                        novaPJ.cnpj = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da empresa");
                        string? rendEntrada = Console.ReadLine();

                        float.TryParse(rendEntrada, out float rendConvertido);
                        novaPJ.rendimento = rendConvertido;

                        //****************************************************

                        Console.WriteLine($"Digite o nome da Rua.");
                        novoEndPJ.logadouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero do imóvel.");
                        string? numEntrada = Console.ReadLine();
                        int.TryParse(numEntrada, out int numConvertido);
                        novoEndPJ.numero = numConvertido;

                        novaPJ.endereco = novoEndPJ;
                        novaPJ.Inserir(novaPJ);

                        // listaPj.Add(novaPJ);

                        Console.WriteLine($"Cadastro realizado com sucesso.");
                        Console.WriteLine($"Pressione qualquer tecla para continuar");
                        Console.ReadLine();

                        //     novaPJ.razaoSocial = "Empresa Senai ME";
                        //     novaPJ.cnpj = "22.777.444/0001-02";

                        //     novaPJ.Inserir(novaPJ);

                        // Console.WriteLine($"Cadastro ok/Arquivo Criado");
                        // Console.ReadLine();
                        
                        break;

                    case "2":

                        Console.Clear();
                        PessoaJuridica novaPJ2 = new PessoaJuridica();
                        List<PessoaJuridica> listaExibicaoPj = novaPJ2.LerArquivo();


                        foreach (var cadaItem in listaExibicaoPj)
                        {
                            
                            Console.WriteLine(@$"
                            
                            Razão Social: {cadaItem.razaoSocial}
                            CNPJ: {cadaItem.cnpj}

                            ");
                            Console.WriteLine($"Linha ok, Enter para Continuar");
                            Console.ReadLine(); 
                            Console.Clear(); 
                        }

                            Console.WriteLine($"Leitura Total Completa");
                            Console.ReadLine();  
                            Console.Clear(); 
 

                        break;



                    case "0":
                        Console.WriteLine($"Volta ao menu anterior");

                        break;

                    default:
                        Console.WriteLine($"Digite o valor correto!");
                        Thread.Sleep(2000);

                        break;
                }

            } while (opcaoPj != "0");


            Thread.Sleep(2000);
            break;

        case "2":
            //DADOS DA PESSOA FISICA ************************************************************

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPF.nome = "Jonatas Silverio";
            novaPF.cpf = "2514521452";
            novaPF.rendimento = 6600.5f;
            novaPF.dataNasc = new DateTime(1992, 02, 02);

            novoEndPF.logadouro = "Av. Doze de Outubro";
            novoEndPF.numero = 229;
            novoEndPF.complemento = "Senai Informatica";
            novoEndPF.endComercial = true;

            novaPF.endereco = novoEndPF;

            //interpolação
            Console.WriteLine(@$"
        Nome: {novaPF.nome}
        Endereço: {novoEndPF.logadouro}, Num: {novoEndPF.numero}
        Maior de idade: {novaPF.validarDataNasc(novaPF.dataNasc)}
        ");

            Console.WriteLine($"Pressione qualquer tecla para continuar");
            Console.ReadLine();
            break;

        case "0":
            Utils.BarraCarregamento();
            Console.Clear();
            break;


        default:
            Console.WriteLine($"digite o valor correto");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");


//*******************************************************