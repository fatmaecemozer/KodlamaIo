using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("computer", "bilgisayar");
            Console.WriteLine(dictionary["computer"]);

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("water", "su");
            myDictionary.Add("apple", "elma");
            foreach (var item in myDictionary.Value)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myDictionary.Count);
        }
    }
    

}
