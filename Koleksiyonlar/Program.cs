using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "erhan", "ece", "ercan", "elveda" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);

            List<string> isimler2 = new List<string> {"ece", "erjan", "erhan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Eroo");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);

        }
    }
}

