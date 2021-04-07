using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            //hangi kredi kullanılacaksa onun hesaplası çalışır
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //hangi logger kullanılacaksa onun log fonk çalışır
        }

        //birden fazla kredinin hesabını yapmak istiyorum list IKrediManager 
        //türünden oluşturdum
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
