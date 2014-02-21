namespace LuboTheHero
{
    public abstract class HeroClassBases
    {
        
        public abstract uint BaseHealth { get; protected set; }

        public abstract uint BaseMana { get; protected set; }

        public abstract uint BaseDamage { get; protected set; }

        public string Name { get; protected set; }


        //changed by Ivo for testing purposes

        public HeroClassBases(string name, uint baseHealth, uint baseMana,uint baseDamage )
        {
            this.Name = name;
            this.BaseDamage = baseDamage;
            this.BaseHealth = baseHealth;
            this.BaseMana = baseMana;
        }
    }
}
