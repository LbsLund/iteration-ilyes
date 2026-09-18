using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            while (myInt >= 1)
            {
                Console.WriteLine(myInt);
                myInt -= 1;

            }
            Console.WriteLine("När myInt är 0 eller mindre så avbryts loopen. Koden körs alltså tre gånger");
            Console.ReadKey();
        }
    }
}