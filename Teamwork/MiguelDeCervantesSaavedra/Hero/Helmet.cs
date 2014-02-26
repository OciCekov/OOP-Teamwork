namespace Hero
{
    using System.Collections.Generic;

    public class Helmet : Armour
    {
        public Helmet(string name, int defence)
            : base(name, ItemType.helmet, defence)
        { }
    }
}
