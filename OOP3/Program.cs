using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface onu Implemente eden sınıfın referans değerini tutabilir.
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(),new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,loggers);
 
            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
