using System;

class Program{
  public static void Main(){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double x = (3.5 * a + 7.5 * b)/11;
    Console.WriteLine($"MEDIA = {x:0.00000}");
  }
}