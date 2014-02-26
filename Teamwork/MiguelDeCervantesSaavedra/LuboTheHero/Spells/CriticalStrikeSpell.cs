
//this is Range Hero spell; Adds 50% chanse to do double dmg
namespace LuboTheHero
{
    using System;
    public class CriticalStrikeSpell : Spell
    {
        public CriticalStrikeSpell(int manaCost, Creature fighter)
            : base(manaCost, fighter)
        {

        }

        //50% shans za critical
        public override void CastOn(Creature fighter)
        {
            // tuka trqbwa da se pomisli za durationa
            var random = new Random();

            if (random.Next(0, 2) == 1)
            {
                this.Fighter.PhysicalDamage *= 2;
            }

            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
