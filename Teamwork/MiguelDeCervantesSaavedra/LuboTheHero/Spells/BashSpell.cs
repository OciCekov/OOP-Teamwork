
//this is fighter spell; adds aditional dmg to the physycal damage of the hero for one attack
namespace LuboTheHero
{
    using System;
    public class BashSpell : Spell
    {
        private const int bashDamage = 5;
        private const int spellDamage = 0;

        public BashSpell(int manaCost, Creature fighter)
            : base(manaCost, fighter)
        {
            this.Damage = spellDamage;           
        }

        //ads five to dmg
        public override void CastOn(Creature fighter)
        {
            //duration?
            fighter.PhysicalDamage += bashDamage;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
