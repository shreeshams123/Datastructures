using System;

namespace Arrayprograms
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4};
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = a.Length - 1; j >= 0; j--)
                {
                    if (i < j)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", a));
        }
    }
}
