using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Aciklama = "Kütür kütür";
            urun2.Fiyati = 20;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }

            Console.WriteLine("-------Metotlar--------");
            //instance - örnek 
            //encapsulation - kapsülleme 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 15,4);
            sepetManager.Ekle2("karpuz", "diyarrr armut", 20,8);
            sepetManager.Ekle2("muz", "alamur muzu ", 13,11);


        }
    }
}


//Don't repeat yourself - DRY - Clean Code - Best Practise