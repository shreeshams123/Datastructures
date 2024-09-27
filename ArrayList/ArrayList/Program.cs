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
            a.AddRange(new ArrayList() { 2, 5, "Rachael", 7.2,"Rachael" });
            int i = 0;
            Console.WriteLine("Elements in arraylist");
            printvalues(a);
            Console.WriteLine(a.Capacity);
            Console.WriteLine(a.Count);
            a.Reverse();
            a.Remove("Rachael");
            Console.WriteLine("After reversing");
            printvalues(a);
            Console.WriteLine(a.Contains("Rachael"));
            object[] arr = new object[a.Count];//As the elements are stored in arraylist as objects.
            foreach(var item in a)
            {
                arr[i++] = item;
            }
            Console.WriteLine("Elements in an array");
            printvalues(arr);
            a.Clear();
            Console.WriteLine(a.Count);
        }
        static void printvalues(IEnumerable a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
