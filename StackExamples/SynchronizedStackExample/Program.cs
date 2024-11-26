using System;
using System.Collections;

namespace SynchronizedStackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            Stack s2 = new Stack(s);//Contents will be copied but the new instance is created
            Console.WriteLine(s2.Equals(s));
            Stack s3 = Stack.Synchronized(s);
            Console.WriteLine(s.IsSynchronized);
            Console.WriteLine(s3.IsSynchronized);
        }
    }
}
