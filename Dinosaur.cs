using System;

namespace JurassicPark
{
    class Dinosaur
    {

        public string Name { get; set; }
        public string DietType { get; set; }
        public int EnclosureNumber { get; set; }
        public int Weight { get; set; }
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
    }
}