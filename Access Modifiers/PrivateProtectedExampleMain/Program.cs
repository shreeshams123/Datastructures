using System;
using PrivateProtectedExample;
namespace PrivateProtectedExampleMain
{
    class Program:Father
    {
        static void Main(string[] args)
        {
            Program p= new Program();
            Console.WriteLine(p.name);
        }
    }
}
