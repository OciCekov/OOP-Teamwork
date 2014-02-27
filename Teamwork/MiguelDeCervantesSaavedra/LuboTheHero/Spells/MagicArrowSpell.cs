//This is Range Hero spell. Adds aditional damage
namespace LuboTheHero.Spells
{
    
    public class MagicArrowSpell : Spell
    {
        private const int magicDamage = 2;
        public MagicArrowSpell(int manaCost, Creature fighter) :
            base(manaCost, fighter)
        {

        }

        public override void CastOn(Creature fighter)
        {
            fighter.Health -= (this.Fighter.PhysicalDamage + magicDamage);
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
