// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Console.WriteLine($"PESSOA JURÍDICA -----------------------------");

using Encontro_Remoto_2.Classes;
string? opcao;

Utils.BarraCarregamento("Iniciando");

do
{

Console.Clear();
Console.WriteLine(@$"

=========================================
|   Bem vindo ao sistema de Cadastro    |
|    de Pessoas Físicas e Jurídicas     |
=========================================
| Digite o número da opção desejada:    |
=========================================
|                                       |
|         1 - Pessoa Física             |
|         2 - Pessoa Jurídica           |
|                                       |
|         0 - Sair                      |
=========================================
");

opcao = Console.ReadLine();
Thread.Sleep(1000);

        switch (opcao)
    {
        case "1":
                    PessoaFisica novaPf = new PessoaFisica();
                    Enderecoo novoEndPf = new Enderecoo();

                    novaPf.nome = "Daniel";
                    novaPf.cpf = "12365478965";
                    novaPf.rendimento = 7000.51f;
                    novaPf.dataNasc = new DateTime (2000,01,01);

                    float resultado = novaPf.CalcularImposto(novaPf.rendimento);
                    Console.WriteLine(resultado);
                    Console.WriteLine($"{resultado.ToString("C")}");
                    DateTime temp = new DateTime(2020,01,01);
                    novaPf.ValidarDataNasc(temp);
                    Console.WriteLine(novaPf.ValidarDataNasc("01/01/2000"));

                    novoEndPf.logradouro = "Rua Guapore";
                    novoEndPf.numero = 318;
                    novoEndPf.complemento = "Apto 203";
                    novoEndPf.endComercial = true;

                    novaPf.endereco = novoEndPf;

                    Console.WriteLine(@$"
                    Nome: {novaPf.nome}
                    Nome da Rua:  {novaPf.endereco.logradouro}
                    Maior de Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
                    ");

                    Console.WriteLine(novaPf.nome);
                    Console.WriteLine(novaPf.cpf);
                    Console.WriteLine($"Nome {novaPf.nome} CPF {novaPf.cpf}");
                    Console.WriteLine($"Para continuar tecle ENTER");
                    Console.ReadLine();

            break;

        case "2":
                    PessoaJuridica novaPj = new PessoaJuridica();

                    float impostoPagar = novaPj.CalcularImposto(2000.5f);
                    Console.WriteLine($"R$ {impostoPagar:0.00}");
                    Console.WriteLine($"{impostoPagar.ToString("C")}");

                    novaPj.Cnpj = "12.436.564/00015-05";

                    Console.WriteLine(@$"
                    CNPJ: {novaPj.Cnpj}
                    Valido: {novaPj.ValidarCnpj(novaPj.Cnpj)}
                    ");
                Console.WriteLine($"Para continuar tecle ENTER");
                Console.ReadLine();
                
            break;

        case "0":
             Console.WriteLine($"Obrigado por utilizar nosso sistema");
        
            break;

        default:
            Console.WriteLine($"Opção Inválida. Informe um dos valores disponíveis para dar andamento");
            Console.WriteLine($"Para continuar tecle ENTER");
            Console.ReadLine();
            break;
    }

} while (opcao != "0");

Utils.BarraCarregamento("Encerrando");



