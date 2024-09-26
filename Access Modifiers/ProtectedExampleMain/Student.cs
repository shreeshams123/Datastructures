using System;

using ProtectedExample;
namespace ProtectedExampleMain
{
    class Student : Person
    {
        static void Main(string[] args)

        {
            Student s= new Student();
            Console.WriteLine(s.name);
        }
    }
}
