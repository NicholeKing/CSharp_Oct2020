using System;

namespace interfaces
{
    public class Mouse : Mammal
    {
        public string furcolor;

        public Mouse(int l, string d, string f) : base(l, d)
        {
            furcolor = f;
        }
    }
}