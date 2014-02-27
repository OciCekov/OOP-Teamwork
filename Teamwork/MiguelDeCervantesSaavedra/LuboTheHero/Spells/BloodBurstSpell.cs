//this is fighter spell; adds 5 to health until next physical attack

using LuboTheHero.Spells;

namespace LuboTheHero
{

    class BloodBurstSpell : Spell
    {
        private const int spellDamage = 0;
        private const int burstHealth = 5;
        public BloodBurstSpell(int manaCost, Creature fighter)
            : base(manaCost, fighter)
        {
            this.Damage = spellDamage;
        }

        //ads 5 to health
        public override void CastOn(Creature fighter)
        {
            //duration?
            fighter.Health += burstHealth;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
