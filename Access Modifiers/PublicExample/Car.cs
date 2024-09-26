using System;
using System.Collections.Generic;
using System.Text;

namespace PublicExample
{
    public class Car
    {
        public string color="Black";
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            Car c=new Car();
            Console.WriteLine(c.color);
            Console.WriteLine(v.Brand);
        }
    }
}
