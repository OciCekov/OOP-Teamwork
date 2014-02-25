namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class Helmet: Armour
    {
        public Helmet(string name, int defence, List<KeyValuePair<string, uint>> requirements)
            : base(name, "helmet", defence, "all", requirements)
        { }
    }
}
