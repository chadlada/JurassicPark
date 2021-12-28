using System;
using System.Collections.Generic;
using System.Linq;


namespace JurassicPark
{
    class Dinosaur
    {
        public string DinoName { get; set; }
        public string DietType { get; set; }
        public DateTime WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
    }

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
            Console.WriteLine("(Q)uit application\n");

            Console.WriteLine("Please choose a letter from the options above, then press ENTER.\n");
            // prompt user to enter their selection. Convert to Upper
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
            var dinosaurs = new List<Dinosaur>();

            DateTime WhenAcquired = DateTime.Now;


            var keepGoing = true;

            while (keepGoing)
            {
                DisplayGreeting();
                var userChoice = Console.ReadLine().ToUpper();

                if (userChoice == "Q")
                {
                    keepGoing = false;
                    Console.WriteLine("Have a roarin' day at Jurassic Park!\n\n\n");
                    break;
                }

                else if (userChoice == "A")
                {
                    var dinosaur = new Dinosaur();

                    dinosaur.DinoName = PromptForString("Dinosaur Name: ");
                    dinosaur.DietType = PromptForString("Diet Type - (C)arnivore / (H)erbivore: ");
                    Console.WriteLine($"Date Acquire {DateTime.Now}");
                    dinosaur.Weight = PromptForInteger("Weight: ");
                    dinosaur.EnclosureNumber = PromptForInteger("Enclosure Number: ");

                    dinosaurs.Add(dinosaur);
                }



                // Console.WriteLine("Would you like to add another Dinosaur to the database? (Y)es/(N)o ");
                // If Yes, loop through fields to add
                // If No, return to menu


            }
        }
    }
}