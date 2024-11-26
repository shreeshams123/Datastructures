using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Text;

namespace StackExamples
{
    class Demo
    {
        static void Main(String[] args)
        {
            Stack st = new Stack();
            Console.WriteLine("Enter elements");
            for (int i = 0; i < 5; i++)
            {
                st.Push(Console.ReadLine());
            }
            Stack st2 = new Stack(st);
            foreach (var i in st2)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(st.Pop());
            }
            Console.WriteLine(st.Equals(st2));
            
        }
    }
}
