
namespace Hero
{
    using System;
    class ManaSuckSpell : Spell
    {
        private const int reduceAttack = 0;
        public ManaSuckSpell(int manaCost, Fighter fighter)
            : base(manaCost, fighter)
        {

        }

        //drains mana
        public override void CastOn(Creature enemy)
        {
            enemy.Mana -= this.Fighter.Mana;
            this.Fighter.Mana -= this.ManaCost;
            this.Target = enemy;
            this.IsCasted = true;
        }
    }
}
