

namespace Hero
{
    using System.Collections.Generic;
    using System.Text;
    public abstract class Fighter : Creature
    {
        public IList<Item> ListOfItems { get; set; }
        public List<Spell> Spells { get; protected set; }
        public Fighter(string name)
        {
            this.ListOfItems = new List<Item>();
            this.Spells = new List<Spell>();
            this.Name =name;
        }
        public virtual void Attack(Enemy fighter)
        {
            fighter.HealthPoints -= this.AttackPoints;
            UpdateHero();
        }
        public virtual void CastSpell(Creature fighter, Spell spell)
        {
            spell.CastOn(fighter);          
        }
        protected abstract void AddSpells();

        public abstract void EquipItem();
        public abstract void DropItem();

        //after each attack
        public void UpdateHero()
        {
            foreach (var spell in Spells)
            {
                if(spell is BashSpell && spell.IsCasted == true)
                {
                    spell.Target.AttackPoints -= 5;
                    spell.IsCasted = false;
                }
                if(spell is BloodBurstSpell && spell.IsCasted == true)
                {
                    spell.Target.HealthPoints -= 5;
                    spell.IsCasted = false;
                }
                if(spell is FreezeSpell && spell.IsCasted == true)
                {
                    spell.Target.AttackPoints = FreezeSpell.initialAttackPoints;
                    FreezeSpell.initialAttackPoints = 0;
                    spell.IsCasted = false;
                }
            }
        }
        public override string ToString()
        {
            
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("- Hero: {0} {1}",this.GetType().Name, this.Name));
            builder.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            builder.AppendLine(string.Format(" *Mana: {0}", this.Mana));
            builder.AppendLine(string.Format(" *AttackPoints: {0}", this.AttackPoints));

            return builder.ToString();
        }
    }
}
