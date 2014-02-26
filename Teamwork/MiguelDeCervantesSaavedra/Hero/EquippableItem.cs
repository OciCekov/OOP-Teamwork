namespace Hero
{
    using System.Collections.Generic;
    public abstract class EquippableItem : Item
    {
        public EquippableItem(string name, ItemType type)
            : base(name, type)
        {
           
        }
    }
}
