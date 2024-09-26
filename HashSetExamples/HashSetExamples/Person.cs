using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HashSetExamples
{
    class Person
    {
        private int id;
        private int age;

        public int Id
        {
            set => id = value;
            get { return id; }
        }
        public int Age
        {
            set => age = value;
            get { return age; }
        }

        public Person(int id, int age)
        {
            Id = id;
            Age = age;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode()+age.GetHashCode();
        }
        public override bool Equals(Object obj)
        {
            Person p = (Person)obj;
            return id == p.id;
        }

    }
    
    class Demo
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();
            people.Add(new Person(1, 10));
            people.Add(new Person(2, 20));
            people.Add(new Person(3, 30));
            foreach (var p in people)
            {
                Console.WriteLine(p.Id + " " + p.Age);
                Console.WriteLine(p.GetHashCode());
            }

            Console.WriteLine("Enter id");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter age");
            int b = int.Parse(Console.ReadLine());
            bool c = true;
           foreach(var p in people)
            {
                if (a.Equals(p.Id))
                {
                    Console.WriteLine("Repeated id not possible");
                    c= false;
                    
                }
            }
            if (c)
            {
                people.Add(new Person(a, b));
                foreach (var p in people)
                {
                    Console.WriteLine(p.Id + " " + p.Age);
                    Console.WriteLine(p.GetHashCode());
                }
            }
            c = true;
            
            
        }
    }
}