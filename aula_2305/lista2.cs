using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite quatro valor inteiros");
    int a = int.Parse( Console.ReadLine() );
    int b = int.Parse( Console.ReadLine() );
    int c = int.Parse( Console.ReadLine() );
    int d = int.Parse( Console.ReadLine() );
    int x = (a * b + c * d / 11);
    Console.WriteLine($"Média = "+ x);
    Console.WriteLine("Números maiores ou iguais a média");
    if (c == d)
    if (c > d)
     Console.WriteLine($"{c}");
    if (d > c)
    Console.WriteLine($"{d}"); 
  }
}