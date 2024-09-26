using System;

namespace ProtectedExample
{
    public class Person
    {
        protected string name = "john";
    }

    class Employee : Person
    {
        static void Main(string[] args)
        {
            Employee e= new Employee();
            Console.WriteLine(e.name);
        }
    }
}
