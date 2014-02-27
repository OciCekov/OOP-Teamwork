using System;
using System.IO;
using System.Runtime.InteropServices;
using LuboTheHero.UIClasses;

namespace LuboTheHero.EvilCreatures
{
    public class BloodHound : Monster
    {
        private const int ImageWidth = 7;
        private const int ImageHeight = 3;
        private const int InitialHealth = 25;
        private const byte InitialPhysicalDamage = 6;
        private const byte InitialSpellDamage = 5;
        private const byte InitialInitiative = 2;
        private const int InitialLineOfSight = 3;

        public BloodHound(MatrixCoords position, byte attack)
            : base(position, InitialHealth, InitialPhysicalDamage, InitialSpellDamage, InitialInitiative, InitialLineOfSight)
        {
            this.Attack = attack;
        }

        #region BloodHound image

        private char[,] LeftMatrix = new char[ImageHeight, ImageWidth]
        {
            {'-', '-', '-', ')', '.', '.', '('},
            {'|', '|', '|', '|', '(', ',', 'o'},
            {'"', ' ', ' ', '"', ' ', ' ', ' '}
        };

        private char[,] RightMatrix = new char[ImageHeight, ImageWidth]
        {
            {')', '.', '.', '(', '-', '-', '-'},
            {'o', ',', ')', '|', '|', '|', '|'},
            {' ', ' ', ' ', '"', ' ', ' ', '"'}
        };


        #endregion

    }
}
