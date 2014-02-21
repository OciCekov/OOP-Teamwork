namespace LuboTheHero
{
    using System;

    public class WizardClass : HeroClassBases
    {
        //changed by Ivo for testing purposes

        public WizardClass(string name, uint baseHealth, uint baseMana,uint baseDamage ) : base(name, baseHealth, baseMana, baseDamage )
        {

        }
        public override uint baseHealth
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public override uint baseMana
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public override uint baseDamage
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }
    }
}
