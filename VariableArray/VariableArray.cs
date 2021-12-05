using System;

namespace VariableArray
{
    class VariableArray
    {
        static void Main(string[] args)
        {
            // 가변배열의 타입은 특정타입[][](더 늘어나도됌)
            // 초기화는 new 특정타입[고정길이][]
            // 즉, 가변배열은 C++의 배열 처럼 사용가능
            int[][] varArray = new int[2][];

            varArray[0] = new int[] { 1, 2 };
            varArray[1] = new int[] { 3, 4, 5 };

            // 가변배열은 Rank 사용시 제대로된 차수 안나옴
            // Length로 써야 함
            //for (int i = 0; i < varArray.Rank; ++i)
            for (int i = 0; i < varArray.Length; ++i)
            {
                for (int j = 0; j < varArray[i].Length; ++j)
                    Console.Write($"{varArray[i][j]} ");
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
    }
}
