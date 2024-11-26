using System;
using System.Collections;
using System.Text;

namespace StackExamples
{
    class Example
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            Stack s2 = (Stack)s.Clone();
            bool flag = true;
            while (s.Count > 0 && s2.Count > 0)
            {
                var i = s.Pop();
                var j = s2.Pop();
                if (i != j)
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("Same");

            }
            else
            {
                Console.WriteLine("Not same");
            }
        }
    }
}