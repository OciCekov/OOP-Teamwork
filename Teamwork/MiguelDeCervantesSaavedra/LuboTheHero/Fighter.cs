using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public class Fighter : Hero, IRenderable, IMovable
    {
        private const int IMAGE_WIDTH = 7; // v interface-a e sys sbyrkano ime WIDTHT zatova tova raboti, nqkoi moje da go opravi ako mu se zanimava
        new private const int IMAGE_HEIGHT = 4;

        #region Fighter images
        private char[,] leftMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {'\u0336', '\u00F7', '/', 'V', '\\', '/', '\\'},
                {' ',' ', '/', ' ', '\\', '\\', '/'},
                {' ',' ', '\u02E9', ' ', '\u02E9', ' ', ' '},
            };

        private char[,] leftUpMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', '|', ' ', 'H', ' ', ' ', ' '},
                {' ', 'I', '/', 'V', '\\', '/', '\\'},
                {' ', ' ', '/', ' ', '\\', '\\', '/'},
                {' ', ' ', '\u02E9', ' ', '\u02E9', ' ', ' '},
            };

        private char[,] leftDownMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {' ', 'I', '/', 'V', '\\', '/', '\\'},
                {' ', '|', '/', ' ', '\\', '\\', '/'},
                {' ', ' ', '\u02E9', ' ', '\u02E9', ' ', ' '},
            };

        private char[,] rightMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {'/', '\\', '/', 'V', '\\', '\u00F7', '\u0336'},
                {'\\', '/', '/', ' ', '\\', ' ', ' '},
                {' ', ' ', 'L', ' ', 'L', ' ', ' '},
            };

        private char[,] rightUpMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', '|', ' '},
                {'/', '\\', '/', 'V', '\\', 'I', ' '},
                {'\\', '/', '/', ' ', '\\', ' ', ' '},
                {' ', ' ', 'L', ' ', 'L', ' ', ' '},
            };

        private char[,] rightDownMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {'/', '\\', '/', 'V', '\\', 'I', ' '},
                {'\\', '/', '/', ' ', '\\', '|', ' '},
                {' ', ' ', 'L', ' ', 'L', ' ', ' '},
            };
        #endregion
        public char[,] LeftMatrix
        {
            get { return this.leftMatrix; }
        }
        public char[,] LeftUpMatrix
        {
            get { return this.leftUpMatrix; }
        }
        public char[,] LeftDownMatrix
        {
            get { return this.leftDownMatrix; }
        }
        public char[,] RightMatrix
        {
            get { return this.rightMatrix; }
        }
        public char[,] RightUpMatrix
        {
            get { return this.rightUpMatrix; }
        }
        public char[,] RightDownMatrix
        {
            get { return this.rightDownMatrix; }
        }
        public Fighter(string name, MatrixCoords position)
            : base()
        {
            //abilities
            this.Strenght = 3;
            this.Dexterity = 2;
            this.Inteligence = 1;
            this.Wisdom = 1;

            //stats
            this.Health = 10 + this.Strenght;
            this.Mana = 8 + this.Inteligence;
            this.Attack = (byte)(this.Strenght + 3);
            this.PhysicalDamage = (byte)(1 + this.Strenght); //TODO add item damage
            this.SpellDamage = 0;
            this.ExperiencePoints = 1;
            this.initiative = (byte)(2 + this.Dexterity);
            this.LineOfSight = 2;

            //reduction
            this.Armour = (byte)(2 + this.Dexterity); //plus items worn
            this.Reflex = this.Dexterity;
            this.Vitality = (byte)(1 + this.Strenght);
            this.WillPower = this.Wisdom;
            this.SkillPoints = 2;
            this.SpellPoints = 1;
            this.Level = 1;
            this.Name = name;

            //this.MyInventory = new Inventory();
            //state
            this.IsAlive = true;

            //visuals
            this.CurrentImage = RightUpMatrix;
            this.Position = position;
        }
    }
}
