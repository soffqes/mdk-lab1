using System;
class HelloWorld {
  static void Main() {
    sbyte x = Convert.ToSByte(Console.ReadLine());
    int y = Convert.ToInt32(Math.Abs(x));
    Console.WriteLine(y);
  }
}