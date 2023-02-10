// See https://aka.ms/new-console-template for more information


string nome;
Console.WriteLine($"Olá, tudo bem? Qual o seu nome?");
nome = Console.ReadLine();

string sobrenome;
Console.WriteLine($"Qual o seu sobrenome?");
sobrenome = Console.ReadLine();

int idade;
Console.WriteLine($"Qual sua idade?");
idade = int.Parse (Console.ReadLine());

string corfavorita;
Console.WriteLine ("Qual sua cor favorita?");
corfavorita = Console.ReadLine ();

Console.WriteLine ($"Nome: {nome}");
Console.WriteLine ($"Sobrenome: {sobrenome}");
Console.WriteLine ($"Idade: {idade}");
Console.WriteLine ($"Cor favorita: {corfavorita}");





