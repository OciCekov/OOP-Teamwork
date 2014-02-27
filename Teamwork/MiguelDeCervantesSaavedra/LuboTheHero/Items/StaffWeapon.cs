namespace LuboTheHero.Items
{
    using System.Collections.Generic;

    public class StaffWeapon : Weapon
    {
        public const int IMAGE_HEIGHT = 1;
        public const int IMAGE_WIDTH = 4;

        private char[,] imageMatrix = new char[IMAGE_HEIGHT, IMAGE_WIDTH]
            {
                {'=', '=', '=', '='}
            };

        public StaffWeapon(string name, int minDmg, int maxDmg, List<KeyValuePair<SkillType, uint>> requirements)
            : base(name, ItemType.staffWeapon, minDmg, maxDmg, UserClassType.Wizard, requirements)
        { }

        public override char[,] GetImage()
        {
            return imageMatrix;
        }
    }
}
