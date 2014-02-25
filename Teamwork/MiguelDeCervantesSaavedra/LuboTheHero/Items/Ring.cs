namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Ring : Armour
    {
        public Ring(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "ring", defence, "all", requirements)
        { }
    }
}
