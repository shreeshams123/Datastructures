using System;

namespace MultiDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2,3];
            Console.WriteLine(a.GetLength(0));
            Console.WriteLine("Enter elements");
            for(int i = 0; i < a.GetLength(0); i++)
            {
               for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
