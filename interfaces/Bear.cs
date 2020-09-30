using System;

namespace interfaces
{
    public class Bear : Mammal, IHunt
    {
        public string furColor;
        public string habitat;
        public bool eatsHoney;
        public int speed;

        public string weapon {get;set;}

        public Bear()
        {
            furColor = "Brown";
            habitat = "Forest";
            eatsHoney = true;
            speed = 10;
        }

        public Bear(int l, string d, string f, string h, bool eh, int s, string w) : base(l, d)
        {
            furColor = f;
            habitat = h;
            eatsHoney = eh;
            speed = s;
            weapon = w;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Oh dear");
        }

        public void MakeNoise2(string message)
        {
            Console.WriteLine(message);
        }

        public override void printStats()
        {
            base.printStats();
            Console.WriteLine("Fur color: " + furColor);
            Console.WriteLine("Habitat: " + habitat);
            Console.WriteLine("Eats honey: " + eatsHoney);
            Console.WriteLine("Speed: " + speed);
        }

        public void hunt()
        {
            Console.WriteLine("Bear hunted something");
        }
    }
}