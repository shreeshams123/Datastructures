using System;

namespace ProtectedInternalExample
{
    public class Parent
    {
        protected internal int id = 5;
    }
    public class OtherClass 
    {
        static void Main(string[] args)
    {
        Parent p= new Parent();
        Console.WriteLine(p.id);
    }
    }
}
