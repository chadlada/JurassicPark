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
            Console.WriteLine("    Welcome to Jurassic Park    ");
            Console.WriteLine("----------------------------------------\n\n\n");

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
                    // make new employee object
                    var dinosaur = new Dinosaur();

                    dinosaur.DinoName = PromptForString("Dinosaur Name: ");
                    dinosaur.DietType = PromptForString("Diet Type - (C)arnivore or (H)erbivore: ");
                    dinosaur.WhenAcquired = DateTime.Now;
                    // Console.WriteLine($"Date Acquire {DateTime.Now}");
                    dinosaur.Weight = PromptForInteger("Weight: ");
                    dinosaur.EnclosureNumber = PromptForInteger("Enclosure Number: ");

                    dinosaurs.Add(dinosaur);
                }
                else if (userChoice == "C")
                {

                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine("The following dinosaurs are in our collection:\n");
                        Console.WriteLine($"Dino Name: {dinosaur.DinoName}");
                        Console.WriteLine($"Dino Diet Type: {dinosaur.DietType}");
                        Console.WriteLine($"Enclosure Number: {dinosaur.EnclosureNumber}");
                        Console.WriteLine($"When Acquired: {dinosaur.WhenAcquired}");
                        Console.WriteLine($"Weight: {dinosaur.Weight}");
                    }

                    if (dinosaurs == null)
                    {
                        Console.WriteLine("No dinosaurs in collection");
                    }
                }

                else if (userChoice == "R")
                {
                    var nameToSearchFor = PromptForString("Which name would you like to remove?: \n");
                    Dinosaur foundDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.DinoName == nameToSearchFor);

                    if (foundDinosaur == null)

                    {
                        Console.WriteLine("No such dinosaur in collection\n\n\n\n");
                    }

                    else
                    {
                        Console.WriteLine($"Remove: {foundDinosaur.DinoName} ");
                        var confirm = PromptForString("Are you sure [Y/N] ").ToUpper();

                        if (confirm == "Y")
                        {
                            dinosaurs.Remove(foundDinosaur);
                        }

                    }

                }
                else if (userChoice == "S")
                {
                    var numCarnivore = dinosaurs.Count(dinosaur => dinosaur.DietType == "C");
                    var numHerbivore = dinosaurs.Count(dinosaur => dinosaur.DietType == "H");

                    if (numCarnivore == 0 && numHerbivore == 0)
                    {
                        Console.WriteLine("There are no such dinosaur in these parts!");
                    }
                    else if (numCarnivore != 0 || numHerbivore != 0)
                    {
                        Console.WriteLine("Here's a summary of our collections diet types");
                        Console.WriteLine($"Carnivore Count: {numCarnivore}");
                        Console.WriteLine($"Herbivore Count: {numHerbivore}");
                    }

                }
                else if (userChoice == "T")
                {
                    var nameToSearchFor = PromptForString("Which dinosaur would you like to transfer?");
                    Dinosaur foundDinosaur = dinosaurs.FirstOrDefault(dinosaur => dinosaur.DinoName == nameToSearchFor);

                    if (foundDinosaur == null)
                    {
                        Console.WriteLine("No such dino in these here parts!");
                    }
                    else
                    {
                        Console.WriteLine($"Transfer {foundDinosaur.DinoName} ");
                        var confirm = PromptForString("Are you sure? [Y/N] ").ToUpper();
                        if (confirm == "Y")
                        {
                            foundDinosaur.EnclosureNumber = PromptForInteger("Enter new enclosure number: ");
                        }

                        Console.WriteLine($"{foundDinosaur.DinoName} has been transferred to {foundDinosaur.EnclosureNumber}");
                    }
                }
                else if (userChoice == "V")
                {
                    foreach (var dinosaur in dinosaurs)
                    {
                        // var viewDinoName = dinosaurs.First(dinosaur => dinosaur.DinoName == dinosaur.DinoName);
                        // var viewWhenAcquired = dinosaurs.Count(dinosaur => dinosaur.WhenAcquired == dinosaur.WhenAcquired);
                        Console.WriteLine($"Dino Name: {dinosaur.DinoName}\nWhen Acquired: {dinosaur.WhenAcquired} ");
                    }

                    if (dinosaurs == null)
                    {
                        Console.WriteLine("No dinos in collection.");
                    }
                }
            }
            // End of While Loop
        }
        // End of Main
    }
    // End of Program
}
