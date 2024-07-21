using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediBaseManager krediBaseManager,List<ILoggerService> loggerServices)
        {
            //Basvuru bilgilerini değerlendirme
            krediBaseManager.Hesapla();
            foreach ( var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
