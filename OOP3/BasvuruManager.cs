using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Müşteri hangi krediyi seçmişse ona göre işlem yapılmasını istiyoruz.

        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)  //Bütün kredilerin referansını tutan IKrediManager interface'i olduğu  
        {                                                                                        //için o tipte bir kredi girilmesini sağladık.

            //Başvuran bilgilerini değerlendirme...
            //
            //

            krediManager.Hesapla();    //Girilen kredinin hesapla operasyonu çalışacak.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
