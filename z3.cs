using System;
class HelloWorld {
  static void Main() {
        sbyte a = Convert.ToSByte(Console.ReadLine());
        sbyte b = Convert.ToSByte(Console.ReadLine());
        int c = Convert.ToInt32(Math.Min(a, b));
        Console.WriteLine(c);
  }
}