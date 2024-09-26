using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes
{
    public class NullOperator
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b;
            b = a ?? 0;
            Console.WriteLine(b);
        }
    }
}
