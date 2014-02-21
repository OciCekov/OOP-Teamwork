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

        /* abilityMin (byte)
        - abilityMax (byte)
        - abilityCurrent (byte)*/


    }
}
