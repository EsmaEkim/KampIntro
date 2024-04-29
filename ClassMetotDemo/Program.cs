using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kunde> kunden = new List<Kunde>();
            Kunde kunde1 = new Kunde { Vorname = "Hans", Nachname = "Müller", Id = 1 };
            Kunde kunde2 = new Kunde { Vorname = "Helga", Nachname = "Schiller", Id = 2 };
            Kunde kunde3 = new Kunde { Vorname = "Esma", Nachname = "Ekim", Id = 3 };

            kunden.Add(kunde1);
            kunden.Add(kunde2);
            kunden.Add(kunde3);

            KundenManager kundemanager = new KundenManager();
            kundemanager.Hinzufügen(kunden);
            kundemanager.List(kunden);
            kundemanager.Löschen(kunde3);
            Console.ReadKey();


        }
    }
}
