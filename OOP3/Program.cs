using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerservice = new DatabaseLoggerService();
            ILoggerService fileLoggerservice = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerservice, fileLoggerservice };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasitKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);







        }
    }
}
