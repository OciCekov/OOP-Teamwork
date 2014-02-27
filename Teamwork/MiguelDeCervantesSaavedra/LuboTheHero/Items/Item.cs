namespace LuboTheHero.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }

        public Item(string name, ItemType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public abstract char[,] GetImage();
    }
}
