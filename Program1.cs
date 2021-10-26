using System;
using System.Collections.Generic;

namespace konsolapplikation
{
    class Program1 : IProgram, INewInterface
    {
        public static void MetodRun()
        {
            Console.WriteLine("Nu kör vi program 1");
        }

        public void MetodSayHello()
        {
            Console.WriteLine("Hello");
        }

        public void MetodStart()
        {
            Console.WriteLine("This does something");
        }
    }
}
