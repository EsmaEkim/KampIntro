using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt1 = new Produkt();
            produkt1.Id = 1;
            produkt1.KategorieId = 2;
            produkt1.ProduktName = "Der Tisch";
            produkt1.StückPreis= 1500;
            produkt1.StückAufLager = 3;


            ProdukteManager produkteManager = new ProdukteManager();
            produkteManager.Hinzufügen(produkt1);




        }
    }
}
