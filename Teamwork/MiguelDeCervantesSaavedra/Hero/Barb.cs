

namespace Hero 
{
    using System.Text;
    public class Barb : Fighter
    {
        private const int initialHealth = 20;
        private const int initialattackPoints = 10;
        private const int initialMana = 8;
      
        public Barb(string name) : base (name)
        {
            this.HealthPoints = initialHealth;
            this.AttackPoints = initialattackPoints;
            this.Mana = initialMana;
            AddSpells();
        }

        protected override void AddSpells()
        {
            this.Spells.Add(new BashSpell(5, this));
            this.Spells.Add(new BloodBurstSpell(2, this));
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
            if(this.ListOfItems.Count > 0)
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
