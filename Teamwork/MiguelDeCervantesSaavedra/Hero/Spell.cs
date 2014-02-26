
namespace Hero
{  
    public abstract class Spell 
    {
        
        private int damage;
        private int manaCost;
        private Fighter fighter;
        private Fighter target;
        private bool isCasted;

        public Spell(int manaCost, Fighter fighter)
        {
            
            this.Damage = damage;
            this.ManaCost = manaCost;
            this.Fighter = fighter;
            this.Target = null;

            
        }

        
        public int Damage { get; protected set; }
        public int ManaCost { get; protected set; }
        public Fighter Fighter { get; protected set; }
        public Creature Target { get; protected set; }
        public bool IsCasted {get; set;}
        public abstract void CastOn(Creature fighter);
       
        
    }
}
