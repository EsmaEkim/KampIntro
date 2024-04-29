using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string> {"Esma","Der September","Der Oktober","Der November" };
            Console.WriteLine(namen[0]);
            Console.WriteLine(namen[1]);
            Console.WriteLine(namen[2]);
            Console.WriteLine(namen[3]);
            namen.Add("Der Herbst");
            Console.WriteLine(namen[4]);
            Console.WriteLine(namen[0]);
            
            
        }
    }
}
