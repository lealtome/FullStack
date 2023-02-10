
// Primeiro passo é abrir uma variavel que suporte o nome do aluno

Console.WriteLine("Qual o nome do aluno?");
string nome = Console.ReadLine();

//Trecho que capta qual o tamanho da lista
int tamanho;
Console.WriteLine("Quantas notas deseja inserir na lista?");
tamanho = int.Parse(Console.ReadLine());
int[] notas = new int [tamanho];

//Trecho que pega as notas de acordo com o tamanho da lista 
for(int i = 0; i < tamanho; i++){
  Console.WriteLine("Digite a nota nº" + (i+1));
  notas[i] = int.Parse(Console.ReadLine());
}
//Trecho que faz soma e determina a media em uma variável
//como fazer operações matemáticas com conteúdo de vetores/array?


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

