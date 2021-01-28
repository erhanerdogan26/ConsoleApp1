using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategoriler"; // metin
            int ogrenciSayisi = 32000; // tam sayılar
            double faizOranı = 1.45; //ondalıklı sayılar
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarDun < dolarBugun) ;
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true) //şart blokları
            {
                Console.WriteLine("kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
          


        }
    }
}
