using System;
using System.Collections;

namespace HashTableExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "alex");
            ht.Add(2, "abc");
            ht.Add('a', "xyz");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine(ht['a']);
            ht.Remove(1);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        
    }
}
