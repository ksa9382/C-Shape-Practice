using System;
using System.Text;

namespace CollectionExample
{
    class Array
    {
        static void Main(string[] args)
        {
            // int Array 1차원
            //int[] intArray;
            //intArray = new int[3];

            //intArray[0] = 1;
            //intArray[1] = 2;
            //intArray[2] = 3;

            //foreach(var elem in intArray)
            //    Console.Write(elem);
            //Console.WriteLine("");
            //for (int i = 0; i < intArray.Length; ++i)
            //    Console.Write($"{intArray[i]} ");
            //Console.WriteLine("");

            // int Array 2차원
            // 선언과 동시에 초기화
            //int[,] intArray2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 }};
            //int[,] intArray3 = new int[,] { { 11, 12, 13 }, { 14, 15, 16 }, { 17, 18, 19 } };

            //int[,] intArray4 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };


            // int Array 3차원
            int[,,] intArray = new int[,,]
            {
               { { 1,2,3,4}, {5,6,7,8}, {9,10,11,12} },
               { {13,14,15,16 }, {17,18,19,20}, {21,22,23,24} }
            };

            int[] dim_length = new int[intArray.Rank];
            string[] indent_string = new string[intArray.Rank];
            const int DEFAULT_INDENT_LENGTH = 4;
            for (int i = 0; i < dim_length.Length; ++i)
            {
                dim_length[i] = intArray.GetLength(i);
                indent_string[i] = new StringBuilder((i + 1) * DEFAULT_INDENT_LENGTH).Insert(0, " ", (i + 1) * DEFAULT_INDENT_LENGTH).ToString();
            }
                

            Console.Write("{\n");
            for (int i = 0; i < dim_length[0];++i)
            {
                Console.Write(indent_string[0] + "{\n");
                for (int j = 0; j < dim_length[1]; ++j)
                {
                    Console.Write(indent_string[1]);
                    Console.Write("{ ");
                    for (int k = 0; k < dim_length[2]; ++k)
                    {
                        Console.Write(intArray[i, j, k]);
                        if (k != dim_length[2] - 1)
                            Console.Write(", ");
                    }
                    Console.Write("}");
                    if (j != dim_length[1] - 1)
                        Console.WriteLine(", ");
                }
                Console.Write("\n" + indent_string[0] + "}");
                if (i != dim_length[0] - 1)
                    Console.WriteLine(", ");
            }
            Console.WriteLine("\n" + "}");
        }
    }
}
