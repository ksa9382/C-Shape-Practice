using System;

namespace NamedParameter
{
    class NamedParameter
    {
        static void Main(string[] args)
        {
            sum(10, 20);            // 기본 형태
            sum(a: 10, b: 20);      // 매개변수 이름과 콜론(:) 기호를 사용하여 호출
            sum(b: 10, a: 20);      // 매개변수 이름을 지정하면 변수 위치 변경 가능
        }

        static void sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
