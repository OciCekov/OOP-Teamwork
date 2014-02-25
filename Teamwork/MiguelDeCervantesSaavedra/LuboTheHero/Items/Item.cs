namespace LuboTheHero.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }

        //owner po princip e null no ako nqkoi go digne ownera stava geroq koito go e dignal
        //eventualno price

        public Item(string name, string type)
        {
            this.Name = name;
        }
    }
}
