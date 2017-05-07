namespace Abstraction.Characters
{
    public class Mage : Character
    {
        private const int DefaultMageHealth = 100;
        private const int DefaultMageDemage = 75;
        private const int DefaultMageMana = 300;

        public Mage()
            : base(DefaultMageHealth, DefaultMageDemage, DefaultMageMana)
        {
        }

        public override void Attack(Character enemy)
        {
            this.Mana -= 100;
            enemy.Health -= 2 * this.Demage;
        }
    }
}
