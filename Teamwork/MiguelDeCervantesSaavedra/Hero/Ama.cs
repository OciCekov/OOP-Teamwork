
namespace Hero
{
    using System.Text;
    class Ama : Fighter
    {
        private const int initialHealth = 15;
        private const int initialattackPoints = 8;
        private const int initialMana = 10;
        public Ama(string name):base(name)
        {
            this.Name = name;
            this.AttackPoints = initialattackPoints;
            this.HealthPoints = initialHealth;
            this.Mana = initialMana;
            AddSpells();
        }
        protected override void AddSpells()
        {
            this.Spells.Add(new CriticalStrikeSpell(2, this));
            this.Spells.Add(new MagicArrowSpell(2, this));
        }

        public override void EquipItem()
        {
            //TODO           
        }

        public override void DropItem()
        {
            //TODO
        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append(base.ToString());
            builder.Append(" *Spells: ");
            foreach (var spell in this.Spells)
            {
                builder.Append(spell.GetType().Name + "; ");
            }
            builder.AppendLine();
            builder.Append(" *Items: ");
            if (this.ListOfItems.Count > 0)
            {
                foreach (var item in this.ListOfItems)
                {
                    builder.Append(item.GetType().Name + "; ");
                }
            }
            else
            {
                builder.Append("No Items");
            }


            return builder.ToString();
        }
    }
}
