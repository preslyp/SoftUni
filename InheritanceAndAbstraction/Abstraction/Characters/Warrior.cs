using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Characters
{
    public class Warrior : Character
    {
        private const int DefaultWarriorHealth = 300;
        private const int DefaultWarriorDemage = 120;
        private const int DefaultWarriorMana = 0;
        public Warrior() 
            : base(DefaultWarriorHealth, DefaultWarriorDemage, DefaultWarriorMana)
        {
        }

        public override void Attack(Character enemy)
        {
            enemy.Health -= this.Demage;
        }
    }
}
