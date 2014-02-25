namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    class BodyArmour: Armour
    {
        public BodyArmour(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "bodyArmour", defence, "all", requirements)
        { }
    }
}
