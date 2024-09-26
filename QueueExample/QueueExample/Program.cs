using System;
using System.Collections;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("Alex");
            q.Enqueue(1.5);
            q.Enqueue(2);
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
        }
    }
}
