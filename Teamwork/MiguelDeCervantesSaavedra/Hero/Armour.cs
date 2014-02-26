namespace Hero
{
    using System.Collections.Generic;
    public abstract class Armour : EquippableItem
    {
        public int Defence { get; set; }

        public Armour(string name, ItemType type, int defence)
            : base(name, type)
        {
            this.Defence = defence;
        }
    }
}
