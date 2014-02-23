namespace LuboTheHero
{
    public class Wisdom : IAbilities
    {
        public Ability AbilityMin { get; private set; }
        public Ability AbilityMax { get; private set; }
        public Ability AbilityCurrent { get; private set; }
        public Ability LooseAbility(Ability oldAbility)
        {
            throw new System.NotImplementedException();
        }

        public Ability AddPoint(Ability oldAbility)
        {
            throw new System.NotImplementedException();
        }
    }
}
