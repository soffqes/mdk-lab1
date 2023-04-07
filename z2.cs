using System;
class HelloWorld {
  static void Main() {
        sbyte a = Convert.ToSByte(Console.ReadLine());
        sbyte b = Convert.ToSByte(Console.ReadLine());
        int c = Convert.ToInt32(Math.Max(a, b));
        Console.WriteLine(c);
  }
}