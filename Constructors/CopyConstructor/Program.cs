using System;

namespace CopyConstructor
{
   class Program
    {
        int age;
        Program(int age)
        {
            this.age = age;
            Console.WriteLine(age);
        }
        Program(Program p)
        {
            this.age = p.age;
            Console.WriteLine(age);
        }
        static void Main(string[] args)
        {
            Program p = new Program(18);
            Program p2 = new Program(p);
            Console.WriteLine("Hello World!");
        }
    }
}
