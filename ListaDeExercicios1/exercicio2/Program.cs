// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calcule a área de um triângulo retângulo!");

Console.WriteLine ("Qual valor da base do triângulo?");
int faceA = int.Parse(Console.ReadLine());

Console.WriteLine ("Qual Valor da altura do triângulo?");
int faceB = int.Parse(Console.ReadLine());

var area = ((faceA * faceB)/2);
Console.WriteLine ($"A área do triângulo retângulo é: {area}");




