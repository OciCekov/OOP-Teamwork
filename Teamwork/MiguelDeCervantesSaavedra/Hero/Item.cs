
namespace Hero
{
    using System.Text;
    public abstract class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }

        public Item(string name, ItemType type)
        {
            this.Name = name;
            this.Type = type;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(this.GetType().Name + " " + this.Name);

            return builder.ToString();
        }
    }
}
