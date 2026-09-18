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
            string name;
            bool inputIsCorrect = false;

            while (inputIsCorrect == false)
            {
                Console.Write("Write your name: ");
                name = Console.ReadLine();
                Console.WriteLine("Your name is: " + name + ". Press Enter to confirm.");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You confirmed" + name + "as your name.");
                    inputIsCorrect = true;
                }
                else
                {
                    Console.WriteLine("You did not confirm" + name + " as your name. Try again!");
                }


            }
            Console.ReadKey(true);
        }
        
    }
}