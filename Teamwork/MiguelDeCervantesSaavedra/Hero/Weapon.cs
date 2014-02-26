namespace Hero
{
    using System.Collections.Generic;

    public abstract class Weapon : EquippableItem
    {       
        public int Dmg { get; protected set; }

        public Weapon(string name, int dmg)
            : base(name,ItemType.weapon)
        {
            this.Dmg = dmg;
        }

    }
}
