namespace LuboTheHero
{
    using System;

    public interface IPickable
    {
        bool PickItem(); // returns true when there is enough space to pick the item (e.g pick succeeded)

        void DropItem(); // droping always succeeds
    }
}
