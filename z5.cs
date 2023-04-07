using System;
class HelloWorld {
  static void Main() {
        decimal h = Convert.ToDecimal(Console.ReadLine());
        int g = Convert.ToInt32(Math.Truncate(h));
        Console.WriteLine(g);
  }
}