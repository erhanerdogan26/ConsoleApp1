using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "erhan";
            int yas = 21;

            Kurs kurs1= new Kurs();
            kurs1.KursADi = "c#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 60;

            Kurs kurs2 = new Kurs();
            kurs2.KursADi = "Python";
            kurs2.Egitmen = "Elif";
            kurs2.IzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursADi = "Java";
            kurs3.Egitmen = "Erhan";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursADi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursADi+" " + kurs.Egitmen + " " + kurs.IzlenmeOrani);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursADi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
