using System;
namespace ProtectedExample
{
    class Person
    {
        protected string name = "John";

    }
    class Employee:Person
    {
        static void Main(string[] args)
        {
            Employee e= new Employee();
            Console.WriteLine(e.name);
        }
    }
}
