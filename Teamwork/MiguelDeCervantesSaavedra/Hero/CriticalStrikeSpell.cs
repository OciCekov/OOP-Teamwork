
namespace Hero
{
    using System;
    public class CriticalStrikeSpell : Spell
    {
        public CriticalStrikeSpell(int manaCost, Fighter fighter)
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
                this.Fighter.AttackPoints *= 2;
            }

            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
