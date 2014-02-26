namespace Hero
{
    using System.Collections.Generic;
    class BodyArmour : Armour
    {
        public BodyArmour(string name, int defence)
            : base(name, ItemType.bodyArmour, defence)
        { }
    }
}
