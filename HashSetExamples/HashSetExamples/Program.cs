using System;
using System.Collections.Generic;

namespace HashSetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>() { 1, 2, 3, 4, 5 };
            int[] a = new int[set.Count];
            int j = 0;
            foreach(int i in set)
            {
                a[j++] = i;
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            set.Add(1);
            set.Add(2);
            Console.WriteLine(set.Add(3));
            Console.WriteLine(set.Count);
            Console.WriteLine(set.Add(2));
            Console.WriteLine(set.Remove(1));
        
        }
    }
}
