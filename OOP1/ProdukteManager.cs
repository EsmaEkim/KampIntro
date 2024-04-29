using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProdukteManager
    {   
        //encapsulation
        //string //ad
        public void Hinzufügen(Produkt produkt)
        {
            Console.WriteLine(produkt.ProduktName + "Dem Warenkorb hinzugefügt.");
        }
        public void Update(Produkt produkt)
        {
            Console.WriteLine(produkt.ProduktName+ "Aktualisiert.");
        }
        

    }
}
