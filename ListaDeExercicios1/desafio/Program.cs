
int tamanho;

Console.WriteLine("Quantos nomes terão na lista?");
tamanho = int.Parse(Console.ReadLine());

string[] nomes = new string[tamanho];


for(int i = 0; i < tamanho; i++){
  Console.WriteLine("Digite o " + (i+1)  + " Nome: ");
  nomes[i] = Console.ReadLine();
}

for(int i = 0; i < tamanho; i++){
  Console.WriteLine("O " + (i+1) + " nome é : "+ nomes[i]);
}
