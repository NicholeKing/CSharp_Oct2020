using System;

namespace inheritance
{
    public class Bear : Mammal
    {
        public string furColor;
        public string habitat;
        public bool eatsHoney;
        public int speed;

        public Bear()
        {
            furColor = "Brown";
            habitat = "Forest";
            eatsHoney = true;
            speed = 10;
        }

        public Bear(int l, string d, string f, string h, bool eh, int s) : base(l, d)
        {
            furColor = f;
            habitat = h;
            eatsHoney = eh;
            speed = s;
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
    }
}