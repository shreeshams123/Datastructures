using System;
using System.Runtime.CompilerServices;

namespace StaticConstructor
{
    class Demo
    {
        static int age;
        static Demo()
        {
            age = 18;
            Console.WriteLine("Age is "+age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
