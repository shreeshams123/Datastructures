using System;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Datatypes
{
   class Demo
    {
        int a = 5;
        float b = 1244647356475.4f;
        
        int j;
        float c;
        public Demo()
        {
            j = (int)b;
            c = a;
            }

        static void Main(string[] args)
        {
            Demo demo = new Demo();
            Console.WriteLine(demo.a);
            Console.WriteLine(demo.b);
            Console.WriteLine(demo.c);
            Console.WriteLine(demo.j);

        }
    }
}
