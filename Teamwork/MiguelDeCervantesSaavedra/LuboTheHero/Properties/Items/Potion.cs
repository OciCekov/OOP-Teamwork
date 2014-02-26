namespace LuboTheHero.Items
{
    public abstract class Potion : Item
    {
        public int RecoveredValue { get; set; }
        public Potion(string name, ItemType type, int recoveredValue)
            : base(name, type)
        {
            this.RecoveredValue = recoveredValue;
        }
    }
}
