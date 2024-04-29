using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class KundenManager
    {
        List<Kunde> _kundeList;

        public KundenManager(List<Kunde> kundeList)
        {
            _kundeList = kundeList;
        }
        public KundenManager()
        {

        }
        public void Hinzufügen(List<Kunde> kunden)
        {
            foreach (Kunde x in kunden)
            {
                Console.WriteLine("Wurden erfolgreich hinzugefügt, Kunde namens: "+x.Vorname +" "+ x.Nachname);
            }
            
        }

        public void List(List<Kunde> kunden)
        {
            foreach(Kunde x in kunden)
            {
                Console.WriteLine("Id: " + x.Id);
                Console.WriteLine("Vorname: " + x.Vorname);
                Console.WriteLine("Nachname: " + x.Nachname);

            }
        }
        public void Löschen(Kunde kunden)
        {
            Console.WriteLine("Der Kunde wurde erfolgreich gelöscht.");
            Console.ReadLine();
        }
    }

}
