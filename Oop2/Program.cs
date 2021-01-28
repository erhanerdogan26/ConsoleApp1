using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erhan Erdoğan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "123123";
            musteri1.FirstName = "Erhan";
            musteri1.LastName = "Erdoğan";

            //peakperformans
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.CompanyName = "Peak performans";
            musteri2.Id = 2;
            musteri2.CustomerNumber = "1223";
            musteri2.VergiNo = "123123123";


            // Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

            

            
            
        }
    }
}
