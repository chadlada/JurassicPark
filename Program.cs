using System;
using System.Collections.Generic;

namespace JurassicPark
{


    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Jurassic Park    ");
            Console.WriteLine("----------------------------------------\n");

            Console.WriteLine("-*-*-*-*-*-*-*-*-MENU-*-*-*-*-*-*-*-*-\n");
            Console.WriteLine("What would you like to do?\n");

            Console.WriteLine("Collections Management:\n");
            Console.WriteLine("(A)dd - New dinosaur to collection");
            Console.WriteLine("(R)emove dinosaur from collection");
            Console.WriteLine("(T)ransfer a dinosaurs enclosure\n");

            Console.WriteLine("Reports:\n");
            Console.WriteLine("(C)collection details of all dinosaurs and their properties");
            Console.WriteLine("(S)summary of diet types");
            Console.WriteLine("(V)iew Dinosaurs and date acquired");
            Console.WriteLine("(Q)uit application");

            Console.WriteLine("Please choose a letter from the options above, then press ENTER.\n");

            // prompt user to enter their selection. Convert to Upper
            var userChoice = Console.ReadLine().ToUpper();
        }



        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            DisplayGreeting();
        }

    }
}