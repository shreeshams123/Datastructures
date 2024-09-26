using System;
using System.Collections.Generic;

namespace HashSetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            Console.WriteLine(set.Add(3));
            Console.WriteLine(set.Count);
            Console.WriteLine(set.Add(2));
            Console.WriteLine(set.Remove(1));
        
        }
    }
}
