using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Bear();
            Mammal m2 = new Mouse(7, "Herbivore", "brown");
            Bear b1 = new Bear();
            Bear b2 = new Bear(4, "Honey Diet", "Yellow", "100 Acre Woods", true, 2, "Claws");
            Mammal b3 = new Bear();
            Mouse mouse1 = new Mouse(4, "herbivore", "White");
            Console.WriteLine(b2.weapon);
            Console.WriteLine(b1.furColor);
            b2.hunt();
        }
    }
}
