using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolapplikation
{
    class Program2 : IProgram
    {
        public static void MetodGo()
        {
            Console.WriteLine("Nu kör vi program 2");
        }

        public void MetodStart()
        {
            Console.WriteLine("This does something");
        }
    }
}
