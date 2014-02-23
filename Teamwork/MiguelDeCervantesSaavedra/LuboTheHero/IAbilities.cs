namespace LuboTheHero
{
    public interface IAbilities
    {
        //Idea properties
        //  Ability IncreaseAbility { get; }               //This are just ideas, you can "screw"them.
        //  Ability DecreaseAbility { get; }               //This are just ideas, you can "screw"them.

        // Kind a "need to be" properties

        Ability AbilityMin { get; }

        Ability AbilityMax { get; }

        Ability AbilityCurrent { get; }

        LuboTheHero.Ability LooseAbility(LuboTheHero.Ability oldAbility);

        LuboTheHero.Ability AddPoint(LuboTheHero.Ability oldAbility);

        /* abilityMin (byte)
        - abilityMax (byte)
        - abilityCurrent (byte)*/


    }
}
