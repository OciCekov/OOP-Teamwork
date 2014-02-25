namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public abstract class EquippableItem :Item
    {
        public string ClassConstraint { get; protected set; }
        public IList<KeyValuePair<string, uint>> Requirements { get; set; }

        public EquippableItem(string name, string type, string classConstr, List<KeyValuePair<string, uint>> requirements) 
            : base(name, "equippableItem")
        {
            this.ClassConstraint = classConstr;
            this.Requirements=requirements;
        }
    }
}
