﻿
namespace Hero
{

    class BloodBurstSpell : Spell
    {
        private const int spellDamage = 0;
        private const int burstHealth = 5;
        public BloodBurstSpell(int manaCost, Fighter fighter)
            : base(manaCost, fighter)
        {
            this.Damage = spellDamage;
        }

        //ads 5 to health
        public override void CastOn(Creature fighter)
        {
            //duration?
            fighter.HealthPoints += burstHealth;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
