// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Encontro_Remoto_2.Classes;

Console.WriteLine($"PESSOA FÍSICA -----------------------------");
PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica();
Enderecoo novoEndPf = new Enderecoo();

novaPf.nome = "Daniel";
novaPf.cpf = "12365478965";
novaPf.rendimento = 7000.51f;
novaPf.dataNasc = new DateTime (2000,01,01);

float resultado = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(resultado);
Console.WriteLine($"{resultado.ToString("C")}");
Console.WriteLine($"-----------------------------");
DateTime temp = new DateTime(2020,01,01);
// novaPf.ValidarDataNasc(temp);
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



// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine($"Nome {novaPf.nome} CPF {novaPf.cpf}");

Console.WriteLine($"PESSOA JURÍDICA -----------------------------");

float impostoPagar = novaPj.CalcularImposto(2000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"{impostoPagar.ToString("C")}");
