using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Mammal();
            Mammal m2 = new Mammal(7, "Herbivore");
            Console.WriteLine(m1.diet);
            Console.WriteLine(m2.diet);
            m1.MakeNoise();
            m2.MakeNoise();
            Bear b1 = new Bear();
            Console.WriteLine(b1.legs);
            Bear b2 = new Bear(4, "Honey Diet", "Yellow", "100 Acre Woods", true, 2);
            Console.WriteLine(b2.habitat);
            b2.MakeNoise2("TIGERRRRRR");
            b2.printStats();
            //YES
            Mammal b3 = new Bear();
            //NO
            //Bear m3 = new Mammal();
            b3.MakeNoise();
        }
    }
}
