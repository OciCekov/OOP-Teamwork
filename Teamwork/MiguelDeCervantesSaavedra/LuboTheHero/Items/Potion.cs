namespace LuboTheHero.Items
{
    public class Potion : Item 
    {
        public string SubType { get; set; }
        public int RecoveredValue { get; set; }
        public Potion(string name, int recoveredValue)
            : base(name, "potion")
        {
            this.RecoveredValue = recoveredValue;
        }
    }
}
