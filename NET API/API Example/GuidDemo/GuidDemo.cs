using System;
using System.Collections.Generic;

namespace GuidDemo
{
    class GuidDemo
    {
        static void Main(string[] args)
        {
            Console.Write("랜덤으로 생성할 문자를 입력하시오: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> strings = new Dictionary<string, int>();
            for (int i = 0; i < count; ++i)
            {
                string unique = Guid.NewGuid().ToString();

                if (strings.ContainsKey(unique))
                    strings[unique]++;
                else
                    strings.Add(unique, 1);
            }

            foreach (var string_pair in strings)
                Console.WriteLine($"Key: {string_pair.Key}, Count: {string_pair.Value}");
        }
    }
}
