using System;

class Program{
  public static void Main(){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double x = (b * c);
    Console.WriteLine($"NUMBER = " +a);
    Console.WriteLine($"SALARY = U$ {x:0.00}");
  }
}