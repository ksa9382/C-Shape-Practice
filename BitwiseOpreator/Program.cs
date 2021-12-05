using System;

namespace BitwiseOpreator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 0b1010;
            byte y = 0b1100;

            Console.WriteLine($"x: {Convert.ToString(x, 2).PadLeft(8, '0')}, 십진수: {x}");
            Console.WriteLine($"y: {Convert.ToString(y, 2).PadLeft(8, '0')}, 십진수: {y}");

            Console.WriteLine($"x & y: {Convert.ToString(x & y, 2).PadLeft(8, '0')}, 십진수: {x & y}");
            Console.WriteLine($"x | y: {Convert.ToString(x | y, 2).PadLeft(8, '0')}, 십진수: {x | y}");
            Console.WriteLine($"x ^ y: {Convert.ToString(x ^ y, 2).PadLeft(8, '0')}, 십진수: {x ^ y}");
            Console.WriteLine($"~x: {Convert.ToString(~x, 2).PadLeft(8, '0')}, 십진수: {~x}");
            Console.WriteLine($"~y: {Convert.ToString(~y, 2).PadLeft(8, '0')}, 십진수: {~y}");
        }
    }
}
