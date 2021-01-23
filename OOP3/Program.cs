using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager = 
                new IhtiyacKrediManager();
            IKrediBaseManager tasitKrediManager =
                new TasitKrediManager();
            IKrediBaseManager konutKrediManager =
                new KonutKrediManager();

            ILoggerService databaseLoggerSevice = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager =
                new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,
                new DatabaseLoggerService());

            List<IKrediBaseManager> krediler = 
                new List<IKrediBaseManager>() {ihtiyacKrediManager, tasitKrediManager};

          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
