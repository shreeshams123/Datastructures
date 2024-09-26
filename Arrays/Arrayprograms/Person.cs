using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrayprograms
{
    public class Person
    {
        private int id;
        private string name;
        private int age;

        public int Id{
            get;
            set;
            }
        public string Name{ get; set; }
        public int Age{ get; set; }
        Person(int id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        static void Main(string[] args)
        {
            Person[] person =
            {
                new Person(1,"shreesha",18),
                new Person(2,"Alex",22)
            };
            var sorted=person.OrderBy(person=>person.Age);
           foreach(var item in sorted)
            {
                Console.WriteLine(item.Age);
            }
        }

        
    }
}
