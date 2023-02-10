Console.WriteLine($"Insira o primeiro lado do triângulo:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o segundo lado do triângulo:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira o terceiro lado do triângulo:");
int c = int.Parse(Console.ReadLine());

    if (a + b > c || b + c > a || c + b > a) {
        Console.WriteLine("Os valores não correspondem a um triângulo");
}

if (a == b && b == c && c==a) {
    Console.WriteLine("É um triângulo Equilátero");
}
else if (a == b || b == c || c == a) {
    Console.WriteLine("É um triangulo Isósceles");
}
else if (a != b && b != c && c != a) {
    Console.WriteLine("É um triângulo Escaleno");
}