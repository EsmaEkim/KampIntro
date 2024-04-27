using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] kurslar = new string[] { "yazılım geliştirici geliştirme kampı", "java kampı", "programlama için temel kurs" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for Arbeitsvorgang endete");

            foreach (string kurs in kurslar) //dizileri tek tek dolaşmaya yarar(kursları dolaş)
            {
                Console.WriteLine(kurs);
            }

            //mein Bereich1
            string[] wochentage = new string[] { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sontag" };
            


            foreach(string tag in wochentage)
            {
                Console.WriteLine(tag);
            }

            Console.WriteLine("foreach Arbeitsvorgang endete");


            Console.Write("Bitte geben Sie eine Zahl ein: ");
            int zahl = Int32.Parse(Console.ReadLine());


            switch(zahl)
            {
                case 1:Console.WriteLine("Montag"); break;
                case 2:Console.WriteLine("Dienstag"); break;
                case 3: Console.WriteLine("Mittwoch"); break;
                case 4: Console.WriteLine("Donnerstag"); break;
                case 5: Console.WriteLine("Frietag"); break;
                case 6: Console.WriteLine("Samstag"); break;
                case 7: Console.WriteLine("sontag"); break;

                default: Console.WriteLine("Fehler! es gibt keinen solchen Tag."); break;

            }
            

            //mein Bereich2
            string[] derMonat = new string[12];
            derMonat[0] = "Januar";
            derMonat[1] = "Februar";
            derMonat[2] = "Marz";
            derMonat[3] = "April";
            derMonat[4] = "Mai";
            derMonat[5] = "Juni";
            derMonat[6] = "Juli";
            derMonat[7] = "August";
            derMonat[8] = "September";
            derMonat[9] = "Oktober";
            derMonat[10] = "November";
            derMonat[11] = "Dezember";

            for (int i = 0;i < derMonat.Length; i++)
            {
                Console.WriteLine(derMonat[i]);
            }

            Console.WriteLine("for Arbeitsvorgang endete");

            int zahll;          
            Console.Write("Bitte geben Sie eine Zahl ein: ");
            zahll = Convert.ToInt32(Console.ReadLine());

            if (zahll <= 12)
            {
                Console.WriteLine();
                
            }
            else
            {

            }
            








        }
    }
}
