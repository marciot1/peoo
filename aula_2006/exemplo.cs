using System;

class Program{
  public static void Main(){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double x = (2 * a + 3 * b + 5 * c)/10.0;
    Console.WriteLine($"MEDIA = {x:0.0}");
  }
}