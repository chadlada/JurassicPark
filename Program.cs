using System;
using System.Collections.Generic;
using System.Linq;


namespace JurassicPark
{

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
                    Console.Clear();
                    var dinosaur = new Dinosaur();
                    dinosaur.DinoName = PromptForString("Dinosaur Name: ");
                    dinosaur.DietType = PromptForString("Diet Type (C)arnivore or (H)erbivore: ");
                    dinosaur.EnclosureNumber = PromptForInteger("Enclosure Number: ");
                    dinosaur.WhenAcquired = DateTime.Now;
                    dinosaur.Weight = PromptForInteger("Weight: ");
                    dinosaurs.Add(dinosaur);
                    Console.WriteLine($"\n{dinosaur.DinoName} added to database.");
                    Console.WriteLine("\nPress ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (userChoice == "C")
                {
                    Console.Clear();

                    Console.WriteLine("The following dinosaurs are in our collection: \n");
                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine($"Name: {dinosaur.DinoName}");
                        Console.WriteLine($"DietType: {dinosaur.DietType}");
                        Console.WriteLine($"Enclosure#: {dinosaur.EnclosureNumber}");
                        Console.WriteLine($"WhenAcquired: {dinosaur.WhenAcquired}");
                        Console.WriteLine($"Weight: {dinosaur.Weight}\n");
                    }
                    if (dinosaurs == null)
                    {
                        Console.WriteLine("No dinosaurs to report!");
                    }
                    Console.WriteLine("\nPress ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();

                }

                else if (userChoice == "R")
                {
                    Console.Clear();

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
                    Console.WriteLine("\nPress ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (userChoice == "S")
                {
                    Console.Clear();
                    var numbOfCarn = dinosaurs.Count(dinosaur => dinosaur.DietType == "C");
                    var numbOfHerb = dinosaurs.Count(dinosaur => dinosaur.DietType == "H");

                    if (numbOfCarn == 0 && numbOfHerb == 0)
                    {
                        Console.WriteLine("There are no dinos in these parts!");
                    }
                    else if (numbOfCarn != 0 || numbOfHerb != 0)
                    {
                        Console.WriteLine($"Here's a summary of the dinosaur diet types");
                        Console.WriteLine($"Carnivore Count: {numbOfCarn}");
                        Console.WriteLine($"Herbivore Count: {numbOfHerb}");
                        Console.WriteLine($"");
                    }
                    Console.WriteLine("\nPress ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (userChoice == "T")
                {
                    Console.Clear();

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
                    Console.WriteLine("\nPress ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userChoice == "V")
                {
                    Console.Clear();

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
                    Console.WriteLine("\nPress ENTER to return to main menu");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            // End of While Loop
        }
        // End of Main
    }
    // End of Program
}
