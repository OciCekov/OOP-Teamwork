namespace LuboTheHero.Spells
{
    using System;
    using System.Collections.Generic;

    public static class ExtensionMethod
    {
        public static Spell Bash(this List<Spell> list)
        {
            foreach (var spell in list)
            {
                if(spell is BashSpell)
                {
                    return spell;
                }
            }
            throw new ArgumentException("No such spell");
        }
        public static Spell BloodBurst(this List<Spell> list)
        {
            foreach (var spell in list)
            {
                if (spell is BloodBurstSpell)
                {
                    return spell;
                }
            }
            throw new ArgumentException("No such spell");
        }

        public static Spell CriticalStrike(this List<Spell> list)
        {
            foreach (var spell in list)
            {
                if (spell is CriticalStrikeSpell)
                {
                    return spell;
                }
            }
            throw new ArgumentException("No such spell");
        }
        public static Spell Freeze(this List<Spell> list)
        {
            foreach (var spell in list)
            {
                if (spell is FreezeSpell)
                {
                    return spell;
                }
            }
            throw new ArgumentException("No such spell");
        }

        public static Spell ManaSuck(this List<Spell> list)
        {
            foreach (var spell in list)
            {
                if (spell is ManaSuckSpell)
                {
                    return spell;
                }
            }
            throw new ArgumentException("No such spell");
        }
        public static Spell MagicArrow(this List<Spell> list)
        {
            foreach (var spell in list)
            {
                if (spell is MagicArrowSpell)
                {
                    return spell;
                }
            }
            throw new ArgumentException("No such spell");
        }

    }
}
