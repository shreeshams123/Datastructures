using System;
using System.Text;

namespace NonPrimitive
{
    public class StringExample
    {
       
        static void Main(string[] args)
        {
            String str1 = "Alex";
            String str2 = str1;
            String str3 = str1.Replace('A', 'j');
            bool isNewStringCreated = ReferenceEquals(str3, str1);
            Console.WriteLine(isNewStringCreated);
            StringBuilder sb = new StringBuilder("Alex");
            StringBuilder sb2 = new StringBuilder(sb.ToString());
            sb2.Replace('A','j');
            bool isNewString=ReferenceEquals(sb, sb2);
            Console.WriteLine("{0},{1}", sb.ToString(), sb2.ToString());
            Console.WriteLine(isNewString);

            
        }
    }
}
