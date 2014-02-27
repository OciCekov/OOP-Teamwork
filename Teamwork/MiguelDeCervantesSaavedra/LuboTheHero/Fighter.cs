namespace LuboTheHero
{
    using LuboTheHero.UIClasses;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Fighter : Hero, IRenderable, IMovable
    {
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

        public Fighter(MatrixCoords position, string name)
            : base(position)
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
            this.Initiative = (byte)(2 + this.Dexterity);

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
            this.CurrentImage = rightUpMatrix;
        }

        public override char[,] GetImage()
        {
            if (this.DeltaPosition.Equals(MatrixCoords.LeftVector))
            {
                this.CurrentImage = this.leftMatrix;
            }

            else if (this.DeltaPosition.Equals(MatrixCoords.RightVector))
            {
                this.CurrentImage = this.rightMatrix;
            }

            else if (this.DeltaPosition.Equals(MatrixCoords.DownVector))
            {
                if (this.CurrentImage == this.rightDownMatrix || this.CurrentImage == this.rightUpMatrix || this.CurrentImage == this.rightMatrix)
                {
                    this.CurrentImage = this.rightDownMatrix;
                }
                else
                {
                    this.CurrentImage = this.leftDownMatrix;
                }
            }

            else
            {
                if (this.CurrentImage == this.rightDownMatrix || this.CurrentImage == this.rightUpMatrix || this.CurrentImage == this.rightMatrix)
                {
                    this.CurrentImage = this.rightUpMatrix;
                }
                else
                {
                    this.CurrentImage = this.leftUpMatrix;
                }
            }

            return this.CurrentImage;
        }
    }
}
