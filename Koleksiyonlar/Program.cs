using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); hata verir
            //isimler = new string[5]; önceki verileri kaybeder

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            //isimler2.Add("Engin");
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);


            
        }
    }
}
