using System;
using System.Collections.Generic;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Antalya");
            sehirler.Add("Bursa");
            sehirler.Add("İstanbul");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Adana");
            sehirler2.Add("Malatya");
            sehirler2.Add("Adıyaman");
            sehirler2.Add("Iğdır");
            Console.WriteLine(sehirler2.Count);
        }
    }
}
