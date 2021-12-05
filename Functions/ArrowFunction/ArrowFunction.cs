using System;

// 화살표 함수: =>
// 화살표 모양의 연산자인 화살표 연산자(=>, 영어 원문은 'goes to')를 사용하여 메서드 코드를 줄일 수 있다.
// 이를 화살표 함수라고 한다.
// C# 프로그래밍에서 화살표 함수 또는 화살표 메서드는 람다 식(lambda expression)의 또 다른 이름이다.
// 화살표 함수를 사용하면 함수를 줄여서 표현할 수 있다. 
namespace ArrowFunction
{
    class ArrowFunction
    {
        static void Main(string[] args)
        {
            Hi();
            Multiply(b: 30, a: 20);
        }

        static void Hi() => Console.WriteLine("Hi");
        static void Multiply(int a, int b) => Console.WriteLine($"{a} * {b}: {a * b}");
    }
}
