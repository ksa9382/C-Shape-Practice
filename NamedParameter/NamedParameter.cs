using System;

namespace NamedParameter
{
    class NamedParameter
    {
        static void Main(string[] args)
        {
            Sum(10, 20);
            Sum(first: 10, second: 20);
            Sum(second: 20, first: 10);
        }

        static void Sum(int first, int second)
        {
            Console.WriteLine($"{first + second}");
        }
    }
}
