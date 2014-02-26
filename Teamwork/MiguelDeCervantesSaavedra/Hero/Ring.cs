namespace Hero
{
    using System.Collections.Generic;
    public class Ring : Armour
    {
        public Ring(string name, int defence)
            : base(name, ItemType.ring, defence)
        { }
    }
}
