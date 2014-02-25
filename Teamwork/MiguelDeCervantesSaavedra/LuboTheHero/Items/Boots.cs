namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Boots : Armour
    {
        public Boots(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "boots", defence, "all", requirements)
        { }
    }
}
