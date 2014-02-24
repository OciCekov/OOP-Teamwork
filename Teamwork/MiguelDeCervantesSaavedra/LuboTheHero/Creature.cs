using System;

namespace LuboTheHero
{
    public abstract class Creature
    {
        //abilities
        protected byte stregth;
        protected byte dexterity;
        protected byte inteligence;
        protected byte wisdom;

        public byte Strenght
        {
            get { return this.stregth; }
            set { this.stregth = value; }
        }
        public byte Dexterity
        {
            get { return this.dexterity; }
            set { this.dexterity = value; }
        }
        public byte Inteligence
        {
            get { return this.inteligence; }
            set { this.inteligence = value; }
        }
        public byte Wisdom
        {
            get { return this.wisdom; }
            set { this.wisdom = value; }
        }

        //creature stats
        protected int health;
        protected int mana;
        protected byte attack;
        protected byte physicalDamage;
        protected byte spellDamage;
        protected byte initiative;
        protected int lineOfSight; //distance at which a creature can start a fight

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Mana
        {
            get { return this.mana; }
            set { this.mana = value; }
        }
        public byte Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }
        public byte PhysicalDamage
        {
            get { return this.physicalDamage; }
            set { this.physicalDamage = value; }
        }
        public byte SpellDamage
        {
            get { return this.spellDamage; }
            set { this.spellDamage = value; }
        }
        public byte Initiative
        {
            get { return this.initiative; }
            set { this.initiative = value; }
        }
        public int LineOfSight
        {
            get { return this.lineOfSight; }
            set { this.lineOfSight = value; }
        }
        //reduciton
        protected byte armour;
        protected byte reflex;
        protected byte vitality;
        protected byte willPower;

        public byte Armour
        {
            get { return this.armour; }
            set { this.armour = value; }
        }
        public byte Reflex
        {
            get { return this.reflex; }
            set { this.reflex = value; }
        }
        public byte Vitality
        {
            get { return this.vitality; }
            set { this.vitality = value; }
        }
        public byte WillPower
        {
            get { return this.willPower; }
            set { this.willPower = value; }
        }

        //points
        private byte skillPoints;
        private byte spellPoints;
        protected byte experiencePoints;

        public byte SkillPoints
        {
            get { return this.skillPoints; }
            set { this.skillPoints = value; }
        }
        public byte SpellPoints
        {
            get { return this.spellPoints; }
            set { this.spellPoints = value; }
        }
        public byte ExperiencePoints
        {
            get { return this.experiencePoints; }
            set { this.experiencePoints = value; }
        }

        //...
        private string name = "DefaultName";
        private byte level;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public byte Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        //state of the creature
        private bool isAlive;
        private bool isHit;
        private bool isAttacking;
        private bool isDefending;

        public bool IsAlive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }
        public bool IsHit
        {
            get { return this.isHit; }
            set { this.isHit = value; }
        }
        public bool IsAttacking
        {
            get { return this.isAttacking; }
            set { this.isAttacking = value; }
        }
        public bool IsDefending
        {
            get { return this.isDefending; }
            set { this.isDefending = value; }
        }
        public Creature()
        {

        }
    }
}
