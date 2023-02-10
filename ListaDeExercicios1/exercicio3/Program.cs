
int nota1;
int nota2;
int nota3;

Console.WriteLine("Digite a primeira nota:");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
nota3 = int.Parse(Console.ReadLine());

int resultado = ((nota1 + nota2 + nota3)/3);
Console.WriteLine($"A média do aluno é: {resultado}");

if (resultado >= 6) {
    Console.WriteLine ($"Aluno aprovado com: {resultado}");
}
else if (resultado >= 5 && resultado < 6) {
    Console.WriteLine($"Aluno está em recuperação com média: {resultado}");
}
else {
    Console.WriteLine ($"Aluno reprovado com média: {resultado}");
}

