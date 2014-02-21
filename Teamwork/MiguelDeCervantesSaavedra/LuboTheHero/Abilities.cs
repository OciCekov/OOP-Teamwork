namespace LuboTheHero
{
    public abstract class Ability : IAbilities
    {
     

        public abstract Ability AddPoint(Ability oldAbility); // Input Ability, idea is to get some ability and increase it's points

        public abstract Ability LooseAbility(Ability oldAbility); // Input Ability, idea is to get some ability and decrease it's points

        //public abstract Ability AbilityModifier(Ability oldAbility); // Couldn't figure out for what this should be, so.... If you know unkoment it. 
        public Ability AbilityMin { get; private set; }
        public Ability AbilityMax { get; private set; }
        public Ability AbilityCurrent { get; private set; }
    }
}
