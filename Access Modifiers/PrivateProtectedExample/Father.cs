using System;

namespace PrivateProtectedExample
{
    public class Father
    {
      private protected string name = "John";
    }
    class Son:Father
    {
        static void Main(string[] args)
        {
            Son s = new Son() ;
            Console.WriteLine(s.name);
        }
    }
}
