using ProtectedInternalExample;
using System;

namespace ProtectedInternalExampleMain
{
    public class Child:Parent
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.id);
        }
    }
}
