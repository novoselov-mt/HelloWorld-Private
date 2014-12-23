using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld_cs_app
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Hello log4net");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
