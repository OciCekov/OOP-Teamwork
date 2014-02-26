namespace LuboTheHero
{
    using LuboTheHero.Items;

    public interface IHero
    {       
        void PickUp(Item item);

        void Drop(Item item);

        void Equip(EquippableItem itemToEquip);

        void UnEquip(EquippableItem item);

        void LevelUp();
    }
}
