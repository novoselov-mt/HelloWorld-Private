using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorld.Lib;

namespace HelloWorld.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib = new Library();

            Console.WriteLine("{0}", lib.GetGreetings());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
