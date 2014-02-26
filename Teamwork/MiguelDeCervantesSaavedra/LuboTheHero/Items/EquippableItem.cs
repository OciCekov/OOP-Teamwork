namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public abstract class EquippableItem : Item
    {
        public UserClassType ClassConstraints { get; protected set; }
        public IList<KeyValuePair<SkillType, uint>> Requirements { get; set; }

        public EquippableItem(string name, ItemType type, UserClassType classConstr, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, type)
        {
            this.ClassConstraints = classConstr;
            this.Requirements = requirements;
        }
    }
}
