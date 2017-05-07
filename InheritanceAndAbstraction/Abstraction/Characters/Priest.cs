using System;
using Abstraction.Interfaces;

namespace Abstraction.Characters
{
    public class Priest : Character, IHeal
    {
        private const int DefaultPriestHealth = 125;
        private const int DefaultPriestDemage = 100;
        private const int DefaultPriestMana = 200;
        public Priest()
            : base(DefaultPriestHealth, DefaultPriestMana, DefaultPriestDemage)
        {
        }

        public override void Attack(Character enemy)
        {
            enemy.Health -= this.Demage;
            this.Health += this.Demage/10;
        }

        public void Heal(Character character)
        {
            this.Mana -= 100;
            character.Health += 150;
        }
    }
}
