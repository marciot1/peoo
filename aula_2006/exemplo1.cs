using System;

class Program{
  public static void Main(){
   int a = int.Parse(Console.ReadLine());
   int b = int.Parse(Console.ReadLine());
   int c = int.Parse(Console.ReadLine());
   int d = int.Parse(Console.ReadLine());
    int x = (a * b - c * d);
    Console.WriteLine($"DIFERENCA = " +x);
  }
}