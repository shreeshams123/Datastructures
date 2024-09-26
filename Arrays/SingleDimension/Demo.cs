using System;

namespace SingleDimension
{
    class Demo
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine(a);
            Console.WriteLine("Enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine(string.Join(",", a));

        }
    }
}
