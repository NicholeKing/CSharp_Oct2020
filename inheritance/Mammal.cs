using System;

namespace inheritance
{
    public class Mammal
    {
        public bool hasHair = true;
        public int legs;
        public string diet;

        public Mammal()
        {
            legs = 4;
            diet = "Omnivore";
        }

        public Mammal(int l, string d)
        {
            legs = l;
            diet = d;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("RAAAARR");
        }

        public virtual void printStats()
        {
            Console.WriteLine("Has hair: " + hasHair + " Legs" + legs + " Diet: " + diet);
        }
    }
}