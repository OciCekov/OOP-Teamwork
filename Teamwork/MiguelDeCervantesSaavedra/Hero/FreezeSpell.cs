
namespace Hero
{
    class FreezeSpell : Spell
    {
        private const int reduceAttack = 0;
        public static int initialAttackPoints = 0;
        public FreezeSpell(int manaCost, Fighter fighter)
            :base(manaCost, fighter)
        {
            this.Damage = fighter.Mana * (this.ManaCost);
        }

        //zamrazqva i vkarwa dmg raven na mana * duration
        public override void CastOn(Creature enemy)
        {

            initialAttackPoints = enemy.AttackPoints;
            enemy.AttackPoints = reduceAttack;
            enemy.HealthPoints -= this.Damage;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = enemy;
            this.IsCasted = true;
        }
    }
}
