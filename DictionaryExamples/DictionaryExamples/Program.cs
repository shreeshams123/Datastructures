using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "apple");
            dict.Add(2, "banana");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            dict.ContainsKey(2);

            Console.WriteLine(dict.Count);
            dict.Remove(dict.Count);
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            
                }
    }
}
