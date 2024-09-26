using System;

namespace InternalExample
{
    public class College
    {
        internal int id=2;   

    }
    public class Student
    {
        static void Main(string[] args)
        {
            College c=new College();
            Console.WriteLine(c.id);
            
        }
    }
}
