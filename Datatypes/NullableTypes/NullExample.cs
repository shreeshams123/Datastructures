using System;

namespace NullableTypes
{
   public class NullExample
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b;
            if (a !=null) {
                b = (int)a;
            }
            else
            {
                Console.WriteLine("a is null");
            }
        }
    }
}
