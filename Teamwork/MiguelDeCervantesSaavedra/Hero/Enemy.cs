

namespace Hero
{
    using System.Text;
    public class Enemy : Creature
    {
        private const int initialHealth = 5;
        private const int initialMana = 10;
        private const int initialAttack = 2;
        public Enemy(string name)
        {
            this.Name = name;
            this.HealthPoints = initialHealth;
            this.AttackPoints = initialAttack;
            this.Mana = initialMana;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("-Name:  {0}", this.Name));
            builder.AppendLine(string.Format(" *Health: {0}", this.HealthPoints <= 0 ? "Dead" : this.HealthPoints.ToString()));
            builder.AppendLine(string.Format(" *Mana: {0}", this.Mana));
            builder.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));

            return builder.ToString();
        }
    }
}
;