using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_sThatOneThing
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = Age();
            continueprompt();
        }

        static int Age()
        {
            int age;
            bool validresponse;

            do
            {
                validresponse = true;

                Console.WriteLine();
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());

                if (age < 0)
                {
                    validresponse = false;

                    Console.WriteLine();
                    Console.WriteLine("That's not possible. Put in a real age.");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                }

            } while (!validresponse);

            return age;
        }

        static void continueprompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
