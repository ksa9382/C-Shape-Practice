using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime prev;

            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine($"================================================= i: {i} =================================================");
                prev = System.DateTime.Now;
                Console.WriteLine($"Fact({i}) : {Fact(i)}, \nspend time: {System.DateTime.Now - prev}\n");

                prev = System.DateTime.Now;
                Console.WriteLine($"Factorial({i}) : {Factorial(i)}, \nspend time: {System.DateTime.Now - prev}\n");

                prev = System.DateTime.Now;
                Console.WriteLine($"FactorialFor({i}) : {FactorialFor(i)}, \nspend time: {System.DateTime.Now - prev}");
                Console.WriteLine($"============================================================================================================\n");
            }
        }

        /// <summary>
        /// 3항 연산자를 이용한 Factorial 구하기
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static long Fact(int n)
        {
            return (n > 1) ? n * Fact(n - 1) : 1;
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        // 단순한 팩토리얼은 이 방법이 좋음
        static long FactorialFor(int n)
        {
            long result = 1L;

            for (int i = 1; i <= n; ++i)
                result *= i;

            return result;
        }
    }
}
