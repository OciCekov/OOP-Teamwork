namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class Gloves : Armour
    {
        public Gloves(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "gloves", defence, "all", requirements)
        { }
    }
}
