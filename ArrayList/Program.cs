using System;
using System.Collections;
namespace ArrayListsExample

{
   class Program
    {
        public static void Main(string[] args)
        {
           ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("John");
            a.AddRange(new ArrayList() { 2, 5, "Rachael", 7.2 });
            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(a.Capacity);
            Console.WriteLine(a.Count);
            a.Reverse();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            a.Clear();
            Console.WriteLine(a.Count);
        }
    }
}
