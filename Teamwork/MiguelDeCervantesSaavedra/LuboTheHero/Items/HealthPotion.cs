namespace LuboTheHero.Items
{
    public class HealthPotion : Potion
    {
        public HealthPotion(string name, int recoveredHealth)
            : base(name, ItemType.healthPotion, recoveredHealth)
        { }
    }
}
