namespace LuboTheHero.EvilCreatures
{
   public  class ViciousFlower : Monster //  IPrint, this doesn't move, or at least I think it shouldn't move
    {
       public ViciousFlower(byte attack) : base(28,6,4,6,0)
       {
           this.Attack = attack;
           // TODO Figure out something interesting to be impement as a special power in this, don't have eyes wright now.
       }
    }
}
