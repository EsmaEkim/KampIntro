using System;

namespace Metotlar //sich nicht wiederholen/sauberen code
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Name = "Der Apfel";
            urun1.Preis = 15;
            urun1.Erklärung= "Amasya Apfel";

            Urun urun2 = new Urun();
            urun2.Name = "Die Wassermelone";
            urun2.Preis = 80;
            urun2.Erklärung = "Diyarbakır Wassermelone";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Preis);
                Console.WriteLine(urun.Erklärung);
                Console.WriteLine("--------------");

            }

            Console.WriteLine("-------------Metotlar-------------");

            //Beispiel(instance)
            //die Verkapselung(encapsulation)5
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Hinzufügen(urun1);
            sepetmanager.Hinzufügen(urun2);
            
            

            

        }
    }
}
