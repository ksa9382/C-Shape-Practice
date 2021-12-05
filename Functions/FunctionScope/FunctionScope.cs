using System;

// 전역변수와 지역변수 사용
namespace FunctionScope
{
    class FunctionScope
    {
        // 전역변수
        static string message = "전역 변수";

        static void Main(string[] args)
        {
            // 전역변수 출력
            Console.WriteLine(message);

            // 지역변수 출력
            ShowMessage();
        }

        static void ShowMessage()
        {
            // 지역 변수
            string message = "지역 변수";
            Console.WriteLine(message);
        }
    }
}
