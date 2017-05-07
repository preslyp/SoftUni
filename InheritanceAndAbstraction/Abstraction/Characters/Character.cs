using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Interfaces;

namespace Abstraction.Characters
{
    public abstract class Character : IAttack
    {
        protected Character(int health, int mana, int demage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Demage = demage;
        }

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Demage { get; set; }

        public abstract void Attack(Character enemy);
    }
}
