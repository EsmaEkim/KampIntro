using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet
    //CRUD
    class Produkt
    {
        public int Id  { get; set; }
        public int KategorieId { get; set; }
        public string ProduktName { get; set; }
        public double StückPreis { get; set; }
        public int StückAufLager { get; set; }

    }
}
