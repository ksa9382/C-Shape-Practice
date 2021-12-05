using System;

namespace CharStruct
{
    class CharStruct
    {
        static void Main(string[] args)
        {
            Char[] vs = new char[] { 'A', 'a', '1', '\t' };

            foreach (var c in vs)
            {
                if (Char.IsUpper(c))
                    Console.WriteLine($"{c}는 대문자입니다.");
                else if (Char.IsLower(c))
                    Console.WriteLine($"{c}는 소문자입니다.");
                else if (Char.IsDigit(c))
                    Console.WriteLine($"{c}는 숫자입니다.");
                else if (Char.IsWhiteSpace(c))
                    Console.WriteLine($"{c}는 화이트 스페이스입니다.");
                else if (Char.IsControl(c))
                    Console.WriteLine($"{c}는 컨트롤 문자입니다.");
            }
        }
    }
}
