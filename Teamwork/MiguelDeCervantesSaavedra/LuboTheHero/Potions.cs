namespace LuboTheHero
{
    using System;

    public abstract class Potions : IPickable
    {
        public bool PickItem()
        {
            throw new NotImplementedException();
        }

        public void DropItem()
        {
            throw new NotImplementedException();
        }
    }
}
