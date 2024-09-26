using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[3] { 1, 2, 3 };
            a[1] = new int[2] { 6, 8 };
            a[2] = new int[4] { 7, 9,2,7 };
            foreach(var i in a)
            {
                foreach(var j in i )
                Console.WriteLine(j);
            }
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine(a[i][j]);
                }
            }
        }
    }
}
