// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Encontro_Remoto_2.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Daniel";
novaPf.cpf = "12365478965";

Console.WriteLine(novaPf.nome);
Console.WriteLine(novaPf.cpf);

Console.WriteLine($"Nome {novaPf.nome} CPF {novaPf.cpf}");
