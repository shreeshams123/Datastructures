using System;
using System.Collections;

namespace StackExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push(1);
            stk.Push("John");
            stk.Push(2.5);
            foreach(var i in stk)
            {
                Console.WriteLine(i);
            }
            object[]b=stk.ToArray();
            Console.WriteLine(string.Join(", ", b));
           
            Console.WriteLine("After popping element");
            stk.Pop();
            Console.WriteLine(stk.Peek());
        }
    }
}
