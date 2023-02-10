int aux1 = 0;
int aux2 = 1;
int fibo;

for (int i = 0 ; i <20 ; i++) {
fibo = aux1 + aux2;
Console.WriteLine(fibo);
aux1 = aux2;
aux2 = fibo;
}
