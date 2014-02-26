namespace LuboTheHero
{
    using System;
    using LuboTheHero.UIClasses;

    public abstract class Creature : IMovable, IRenderable
    {
        private string name;
        private byte level;
        private MatrixCoords deltaPosition;

        public Creature(MatrixCoords position)
        {
            this.Position = position;
            this.IsAlive = true;
        }

         public Creature(MatrixCoords position, int health, byte phisicalDamage, byte spellDamge, byte initiative, int lineofSight)
             : this(position)
        {
            this.Health = health;
            this.PhysicalDamage = phisicalDamage;
            this.SpellDamage = spellDamge;
            this.Initiative = initiative;                        
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Creature name cannot be emty");
                }
                this.name = value;
            }
        }

        public byte Level { get; set; }

        public char[,] CurrentImage { get; set; }
        
        //abilities
        public byte Strenght { get; set; }

        public byte Dexterity { get; set; }

        public byte Inteligence { get; set; }

        public byte Wisdom { get; set; }

        //creature stats                                
        public int Health { get; set; }

        public int Mana { get; set; }

        public byte Attack { get; protected set; }

        public byte PhysicalDamage { get; set; }

        public byte SpellDamage { get; protected set; }

        public byte Initiative {get; protected set;}        

        //reduciton                            
        public byte Armour { get; set; }

        public byte Reflex { get; set; }

        public byte Vitality { get; set; }

        public byte WillPower { get; set; }

        //points
        public byte SkillPoints { get; protected set; }

        public byte SpellPoints { get; protected set; }

        public byte ExperiencePoints { get; protected set; }                       

        //state of the creature                                
        public bool IsAlive { get; protected set; }

        public bool IsHit { get; protected set; }

        public bool IsAttacking { get; protected set; }

        public bool IsDefending { get; protected set; }        

        public MatrixCoords Position { get; protected set; }

        public MatrixCoords DeltaPosition
        {
            get
            {
                return this.deltaPosition;
            }
            set
            {
                if (value.Row < -1 || value.Row > 1 || value.Col < -1 || value.Col > 1)
                {
                    throw new ArgumentOutOfRangeException("Cannot move with more than one position in each direction");
                }
                this.deltaPosition = value;
            }
        }        

        public void Move()
        {
            this.Position += this.DeltaPosition;
        }

        //a method which determines wheter or not the two oppnents can start a fight
        public static void Fight(Hero hero, Monster monster)
        {
            //if(hero.DistanceTo(monster) <= hero.lineOfSight) -- there will be a method for calculating distances between creatures
            //if both oppnents are alive
            if (hero.IsAlive && monster.IsAlive)
            {
                //if both opponets health is still a positive number
                while (hero.Health > -1 && monster.Health > -1)
                {
                    //whomever has the highest initiative can strike first
                    if (hero.Initiative > monster.Initiative)
                    {
                        Attacking(hero, monster);
                        Defending(hero, monster);
                    }
                    else
                    {
                        Defending(hero, monster);
                        Attacking(hero, monster);
                    }

                }

                /*
                  if (hero.Health <= -1)
                  {
                      hero.IsAlive = false;
                      Console.WriteLine("Monster won the fight.");
                  }
                  if (monster.Health <= -1)
                  {
                      monster.IsAlive = false;
                      Console.WriteLine("{0} won the fight", hero.Name);
                  } */
            }
        }

        public static void Attacking(Hero hero, Monster monster)
        {
            if (hero.IsDefending != true)
            {
                //insert RandomGeneratorVariable 1-10
                if (hero.Attack + 10 >= monster.Armour)
                    hero.IsAttacking = true;
                while (hero.IsAttacking)
                {
                    monster.IsDefending = true;
                    if (hero.PhysicalDamage - monster.Armour > 0)
                    {
                        monster.Health -= (hero.PhysicalDamage - monster.Armour);
                        Console.WriteLine("Damage done {0}", hero.PhysicalDamage - monster.Armour);
                    }
                    else Console.WriteLine("Miss");
                    hero.IsAttacking = false;
                    monster.IsDefending = false;
                }
            }
            hero.UpdateHero();//added by ivo
        }

        public static void Defending(Hero hero, Monster monster)
        {
            if (hero.IsAttacking != true)
            {
                //insert RandomGeneratorVariable 1-10
                if (hero.Armour <= monster.Attack + 10)
                    hero.IsDefending = true;
                while (hero.IsDefending)
                {
                    monster.IsAttacking = true;
                    if (monster.PhysicalDamage - hero.Armour > 0)
                    {
                        hero.Health -= (monster.PhysicalDamage - hero.Armour);
                        Console.WriteLine("Hero health left: {0}", hero.Health);
                    }
                    hero.IsDefending = false;
                    monster.IsAttacking = false;
                }
            }
        }

        public MatrixCoords GetTopLeft()
        {
            return this.Position;
        }

        public abstract char[,] GetImage();
    }
}
