using System;

namespace OutVariable
{
    class OutVariable
    {
        static void Main(string[] args)
        {
            // out var 사용방법
            // C#6 전까지 사용 방법 : 변수를 미리 선언

            int r;
            if (int.TryParse("4321", out r))
            {
                Console.WriteLine("{0}", r);
            }

            // C#7.0 이후 out var 방식
            if (int.TryParse("1234", out var result))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine(result);
        }
    }
}
