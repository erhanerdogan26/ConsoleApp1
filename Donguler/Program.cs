using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi

            string[] kurslar = new string[] {"yazılım geliştici", "Programlamaya başlama", "Java", "c#", "PHP"  };

            for (int i = 0; i <kurslar.Length; i++) // i++ i değerini 1 arttır
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
