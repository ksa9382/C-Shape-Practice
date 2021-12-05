﻿using System;

namespace MethodOverloadNumber
{
    class MethodOverloadNumber
    {
        static void Main(string[] args)
        {
            GetNumber(1234);
            GetNumber(1234L);
        }

        static void GetNumber(int number)
        {
            Console.WriteLine($"Int32 : {number}");
        }

        static void GetNumber(long number)
        {
            Console.WriteLine($"Int64 : {number}");
        }
    }
}
