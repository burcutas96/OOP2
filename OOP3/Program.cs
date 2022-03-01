
using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

//İnterfaceler o interface'i implement eden (miras alan) classın referans numarasını tutar.

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()});

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);


