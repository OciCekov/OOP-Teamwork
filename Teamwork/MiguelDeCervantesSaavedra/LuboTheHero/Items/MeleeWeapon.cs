namespace LuboTheHero.Items
{
    using System.Collections.Generic;
    public class MeleeWeapon : Weapon
    {
        public const int IMAGE_HEIGHT = 3;
        public const int IMAGE_WIDTH = 7;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {' ', ' ', '/', ' ', ' ', ' ', ' '},
                {'o', 'o', '=', '=', '=', '=', '>'},
                {' ',' ', '\\', ' ', ' ', ' ', ' '},
            };
        public MeleeWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.meleeWeapon, minDmg, maxDmg, UserClassType.Fighter, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
