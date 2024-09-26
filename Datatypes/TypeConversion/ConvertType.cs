using System;

namespace TypeConversion
{
    class ConvertType
    {
        static void Main(string[] args)
        {
            float a = 5.2f;
            int b = (int)a;
            int d=Convert.ToInt32(a);
            int i = 5;
            string str2 = i.ToString();
            Console.WriteLine(str2);
            string str = "123";
            int f=int.Parse(str);
            int res = 0;
            bool c = int.TryParse(str,out res);
            if (c)
            {
                res = Convert.ToInt32(str);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine(c);
           
        }
    }
}
