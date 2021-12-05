using System;

// 로컬함수 데모
// C# 7.0부터 로컬 함수 기능제공
// 함수 내에서만 사용하는 또 다른 함수를 만드는것
// 특정 함수 내에서만 사용하는 도 다른 함수를 로컬함수라 한다.

namespace LocalFunctionDemo
{
    class LocalFunctionDemo
    {
        static void Main(string[] args)
        {
            void Display(string text)
            {
                Console.WriteLine(text);
            }

            Display("로컬 함수");
        }
    }
}
