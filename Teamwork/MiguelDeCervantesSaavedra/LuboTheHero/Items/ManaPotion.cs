namespace LuboTheHero.Items
{
    public class ManaPotion : Potion
    {
        public ManaPotion(string name, int recoveredMana)
            : base(name, ItemType.manaPotion, recoveredMana)
        { }
    }
}
