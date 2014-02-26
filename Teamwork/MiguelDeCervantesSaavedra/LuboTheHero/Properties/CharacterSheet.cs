using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class CharacterSheet
    {
        //abilities -- shortened so they do not interfere with similar names of variables
        string Str = "Each point here gives +1 health and +1 vitality. The ability is key for the fighter class, each point gives an addtitional +1 Attack, PhysicalDamage.";
        string Dex = "Each point here gives +1 armour and +1 reflex. The ability is key for the Ranger class, each point gives an additional +1 Attack, PhysicalDamage";
        string Int = "Each point here gives +1 mana. The ability is key for the Wizard class, each point gives +1 SpellDamage";
        string Wis = "Each point here gives +1 Willpower, it also gives bonuses to some spells and skills.";

        //stats -- + M for message, so they do not interfere with similiar names of variables
        string HealthM = "This is your health, if it becomes a negative value you die. It is based on strenght.";
        string ManaM = "This is your mana. Each spell you cast costs you mana.";
        string AttackM = "These are yor physical attack points, the more you have the easier you will hit your enemies.";
        string PhysicalDamageM = "This is your physical damage. It is a combination of the damage of your weapon and your base ability. Base ability varies upon class.";
        string SpellDamageM = "This is the damage done by your spells. It is a combination of the damage of the spell and the base ability. Base ability varies in different spells.";
        string InitiativeM = "This is your initiative. It is a combination of a random number between 1 and 10 and yor Dexterity. It is used to determine who acts first in combat.";
        string lineOfSightM = "This determines wheter your opponent is within attacking range. Varies based on type of attack (Melee/Ranged/Spell).";

        //reduciton
        string ArmourM = "This your armour. It determines how hard it is for you to be hit and how much damage you are going to take from a physical attack. It is based on Dexterity.";
        string ReflexM = "This determines your ability to evade projectiles (e.g. the fireball spell), traps and etc.";
        string VitalityM = "This determines your inner power to reduce damage taken over time (e.g. poisonDamage, the freeze spell)";
        string WillPowerM = "This determines the strnght of your mind. It reduces damage taken by some spells (e.g. LifeDrain), or gives bonus to others (e.g. Heal)";

        //points
        string SkillPointsM = "These are the skill points you receive each lvl to distribute amongst your skills. Wisdom based";
        string SpellPointsM = "These are the spell points you receive to learn new spells or upgrade old ones. Inteligence based.";
        string ExperiencePointsM = "You receive experience points for each creature killed, each dungeon passsed and others. The are needed for gaining Levels.";

        //other
        string LevelM = "This your level, you gain a new one for each 1000 points mulitplied by your current level.";

    }
}
