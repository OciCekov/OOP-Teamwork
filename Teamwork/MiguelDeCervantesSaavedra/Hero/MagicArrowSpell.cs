
namespace Hero
{
    
    public class MagicArrowSpell : Spell
    {
        private const int magicDamage = 2;
        public MagicArrowSpell(int manaCost, Fighter fighter):
            base(manaCost, fighter)
        {

        }

        public override void CastOn(Creature enemy)
        {
            enemy.HealthPoints -= (this.Fighter.AttackPoints + magicDamage);
            this.Fighter.Mana -= this.ManaCost;
            this.Target = enemy;
            this.IsCasted = true;
        }
    }
}
