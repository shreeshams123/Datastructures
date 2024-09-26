using System;
using System.Collections.Generic;
using System.Text;

namespace QueueExample
{
    class Demo
    {
       static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            
            Queue<int> s = new Queue<int>(q);
            s.Enqueue(2);
            s.Enqueue(3);
            s.Enqueue(4);
            foreach (int i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(s.Equals(q));

            
        }
        
    }
}
