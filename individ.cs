//Проверить соотношение: sin(30)=1/2
using System;
class HelloWorld {
  static void Main() {
         double a = Convert.ToDouble(Console.ReadLine());
         double x, y; 
         x = a * Math.PI / 180; //угол в радианах
         y = Math.Sin(x);
         Console.WriteLine(y);
  }
}