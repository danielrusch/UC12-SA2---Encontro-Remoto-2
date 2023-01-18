// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Encontro_Remoto_2.Classes;

Console.WriteLine($"PESSOA FÍSICA -----------------------------");
PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Daniel";
novaPf.cpf = "12365478965";
novaPf.rendimento = 7000.51f;

float resultado = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(resultado);
Console.WriteLine($"{resultado.ToString("C")}");

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine($"Nome {novaPf.nome} CPF {novaPf.cpf}");

Console.WriteLine($"PESSOA JURÍDICA -----------------------------");

PessoaJuridica novaPj = new PessoaJuridica();

float impostoPagar = novaPj.CalcularImposto(2000.5f);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine($"{impostoPagar.ToString("C")}");
