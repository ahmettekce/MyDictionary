using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<>
            MyDictionary<int, string> iller = new MyDictionary<int, string>();
            iller.Add(1,"Adana");
            iller.Add(6,"Ankara");
            iller.Add(7,"Antalya");

            for (int i = 0; i < iller.Count; i++)
            {
                Console.WriteLine($"Plaka Kodu: {iller.Anahtar[i]} - İl: {iller.Deger[i]}");
            }

            Console.WriteLine("Toplam eleman: "+iller.Count);
        }
    }
}
