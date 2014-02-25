
//This is Wizzard Spell. Freezes opponent till next phisical attack, and makes physical dmg
namespace LuboTheHero
{
    class FreezeSpell : Spell
    {
        private const int reduceAttack = 0;
        public static int initialAttackPoints = 0;
        public FreezeSpell(int manaCost, Creature fighter)
            :base(manaCost, fighter)
        {
            this.Damage = fighter.Mana;
        }

        //zamrazqva i vkarwa dmg raven na mana * duration
        public override void CastOn(Creature fighter)
        {
            //tuka durationa e mnogo vajen
            initialAttackPoints = fighter.PhysicalDamage;
            fighter.PhysicalDamage = reduceAttack;
            fighter.Health -= (byte)this.Damage;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
