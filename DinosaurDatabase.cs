using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class DinosaurDatabase
    {
        // var dinosaurs = new List<Dinosaur>();
        private List<Dinosaur> Dinosaurs { get; set; } = new List<Dinosaur>();

        public void AddDino(Dinosaur newDino)
        {
            Dinosaurs.Add(newDino);
        }

        public List<Dinosaur> GetAllDinos()
        {
            return Dinosaurs;
        }
        public Dinosaur FindOneDino(string nameToFind)
        {
            Dinosaur foundDino = Dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name.ToUpper().Contains(nameToFind.ToUpper()));
            return foundDino;
        }

        public void DeleteDino(Dinosaur dinoToDelete)
        {
            Dinosaurs.Remove(dinoToDelete);
        }

    }
}