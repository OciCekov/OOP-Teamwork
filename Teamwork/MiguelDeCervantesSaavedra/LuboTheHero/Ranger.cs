namespace LuboTheHero
{
    public class Ranger : Hero, IHero
    {
        public Ranger(MatrixCoords position, string name)
            : base(position)
        {
            //abilities
            this.Strenght = 2;
            this.Dexterity = 3;
            this.Inteligence = 1;
            this.Wisdom = 1;

            //stats
            this.Health = 9 + this.Strenght;
            this.Mana = 9 + this.Inteligence;
            this.Attack = (byte)(this.Dexterity + 3);
            this.PhysicalDamage = this.Dexterity; //TODO add item damage
            this.SpellDamage = 0;
            this.ExperiencePoints = 1;

            //reduction
            this.Armour = (byte)(2 + this.Dexterity);
            this.Reflex = this.Dexterity;
            this.Vitality = (byte)(1 + this.Strenght);
            this.WillPower = this.Wisdom;
            this.SkillPoints = 2;
            this.SpellPoints = 1;
            this.Level = 1;
            this.Name = name;
        }

        public override char[,] GetImage()
        {
            throw new System.NotImplementedException();
        }
    }
}
