
Console.WriteLine ($"Calcule seu imposto de renda");

Console.WriteLine($"Qual o seu salário bruto?");
int salario = int.Parse(Console.ReadLine());


if (salario <= 900) {
Console.WriteLine("O desconto a ser aplicado é zero");
}
else if (salario > 900 && salario <= 1500) {
   Console.WriteLine ($"O desconto a ser aplicado é: {(salario/100) * 5} Reais");
}

else if (salario > 1500 && salario <= 2500) {
Console.WriteLine($"O desconto a ser aplicado é: {(salario/100) * 10} Reais ");
}
else {
Console.WriteLine($"O desconto a ser aplicado é: {(salario/100) * 20} Reais");
}




