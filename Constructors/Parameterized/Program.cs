using System;

namespace Parameterized
{
     class Program
    {
        int id;
        Program(int age)
        {
            this.id = 2;
            Console.WriteLine("Age is {0}", age);

        }
        Program(string name,int age)
        {
            Console.WriteLine(name,age);
        }
        static void Main(string[] args)
        {

            Program p = new Program(18);
            Program p2 = new Program("shreesha", 22);

        }
    }
}
