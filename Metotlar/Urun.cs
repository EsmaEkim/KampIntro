using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Urun 
    {
        //Unterkunft(property)
        public int Id { get; set; }
        public string Name { get; set; }
        public double Preis { get; set; }
        public string Erklärung { get; set; }

        public int Warenlager { get; set; }

    }
}
