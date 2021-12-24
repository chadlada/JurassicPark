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
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
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
            var database = new DinosaurDatabase();


            DisplayGreeting();

            var keepGoing = true;
            // While the user hasn't said QUIT yet
            while (keepGoing)
            {
                // Insert a blank line then prompt them and get their answer (force uppercase)
                Console.WriteLine();
                Console.Write("What do you want to do?\n(A)dd Dinosaur\n(D)elete Dinosaur\n(S)how all Dinosaurs\n(F)ind/Search Dinosaur\n(T)ransfer/Update\n(Q)uit:\n");
                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "Q":
                        keepGoing = false;
                        break;
                    case "D":
                        DeleteEmployee(database);
                        break;
                    case "F":
                        FindDino(database);
                        break;
                    case "S":
                        ShowAllDinos(database);
                        break;
                    case "T":
                        TransferUpdate(database);
                        break;
                    case "A":
                        AddDino(database);
                        break;
                    default:
                        Console.WriteLine("NOPE!");
                        break;
                }
            }
        }

        private static void DeleteEmployee(DinosaurDatabase database)
        {
            var nameToSearchFor = PromptForString("What name are you looking for? ");
            // Dinosaur foundDino = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameToSearchFor);


            Dinosaur foundDino = database.FindOneDino(nameToSearchFor);

            if (foundDino == null)

            {
                Console.WriteLine("No such dino up in here!");
            }
            else
            {
                Console.WriteLine($"{foundDino.Name} is a {foundDino.DietType}, weighs {foundDino.Weight}, and is located in enclosure # {foundDino.EnclosureNumber}");
                var confirm = PromptForString("Are you sure? [Y/N] ").ToUpper();

                if (confirm == "Y")
                {
                    database.DeleteDino(foundDino);
                }

            }
        }

        private static void TransferDino(DinosaurDatabase database, string choice)
        {

        }

        private static void TransferUpdate(DinosaurDatabase database)
        {
            var nameToSearchFor = PromptForString("What name are you looking for? ");
            Dinosaur foundDino = database.FindOneDino(nameToSearchFor);

            if (foundDino == null)
            {
                Console.WriteLine("No such dino up in here!");
            }
            else
            {
                Console.WriteLine($"{foundDino.Name} is a {foundDino.DietType}, weighs {foundDino.Weight}, and is located in enclosure # {foundDino.EnclosureNumber}");
                var changeChoice = PromptForString("What do you want to change?[Name/Enclosure]? ").ToUpper();

                if (changeChoice == "NAME")
                {
                    foundDino.Name = PromptForString("What is the new name?");
                }
                if (changeChoice == "ENCLOSURE")
                {
                    foundDino.EnclosureNumber = PromptForInteger("What is the new enclosure number? ");
                }

            }
        }

        private static void FindDino(DinosaurDatabase database)
        {
            var nameToSearchFor = PromptForString("What name are you looking for? ");

            Dinosaur foundDino = database.FindOneDino(nameToSearchFor);

            if (foundDino == null)
            {
                Console.WriteLine("No such dino up in here!");
            }
            else
            {
                Console.WriteLine($"{foundDino.Name} is a {foundDino.DietType}, weighs {foundDino.Weight}, and is located in enclosure # {foundDino.EnclosureNumber}");
            }
        }

        private static void AddDino(DinosaurDatabase database)
        {
            var dinosaur = new Dinosaur();
            dinosaur.Name = PromptForString("Dinosaur name: ");
            dinosaur.DietType = PromptForString("Dinosaur diet type: ");
            dinosaur.EnclosureNumber = PromptForInteger("What is the enclosure number: ");
            dinosaur.Weight = PromptForInteger("Dinosaur weight: ");
            // dinosaur.WhenAcquired = DateTime (DateTime);  **HELP**

            database.AddDino(dinosaur);
        }

        private static void ShowAllDinos(DinosaurDatabase database)
        {
            foreach (var dinosaur in database.GetAllDinos())
            {
                Console.WriteLine($"{dinosaur.Name} is a {dinosaur.DietType}, weighs {dinosaur.Weight}, and is located in enclosure # {dinosaur.EnclosureNumber}");
            }
        }
    }
}