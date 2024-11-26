using System;
using System.Collections.Generic;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(4);
            foreach (int i in stk)
            {
                Console.WriteLine(i);
            }
        }
    }
}
