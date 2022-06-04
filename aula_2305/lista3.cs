using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite quatro valor inteiros");
    int a = int.Parse( Console.ReadLine() );
    int b = int.Parse( Console.ReadLine() );
    int c = int.Parse( Console.ReadLine() );
    int d = int.Parse( Console.ReadLine() );
    int soma = (a + b + c);
    Console.WriteLine($"soma dos pares = "+ soma);
    
    Console.WriteLine($"soma dos impares = "+ d);

  }
}