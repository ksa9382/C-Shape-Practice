using System;

namespace CommandLineArgumentDemo
{
    class CommandLineArgumentDemo
    {
        static void Main(string[] args)
        {

            if (args.Length >= 1)
                foreach (var arg in args)
                    Console.WriteLine(arg);
        }
    }
}
