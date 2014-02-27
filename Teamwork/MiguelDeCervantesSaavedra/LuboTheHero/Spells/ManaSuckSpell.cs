//This is a Wizzard spell. Suckes the mana of the opponent
namespace LuboTheHero.Spells
{
    class ManaSuckSpell : Spell
    {
        private const int reduceAttack = 0;
        public ManaSuckSpell(int manaCost, Creature fighter)
            : base(manaCost, fighter)
        {

        }

        //drains mana
        public override void CastOn(Creature fighter)
        {
            fighter.Mana -= this.Fighter.Mana;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = fighter;
            this.IsCasted = true;
        }
    }
}
