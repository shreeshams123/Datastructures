using System;

namespace PrivateConstructor
{
    public class Program
    {
        private Program()
        {

        }
        public static Program Retobj()
        {
            return new Program();
        }
    }
    class NewPro{
        static void Main(string[] args)
        {
            Program p = Program.Retobj();
           
        }
    }
}
