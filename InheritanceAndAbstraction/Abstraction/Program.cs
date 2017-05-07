using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Characters;

namespace Abstraction
{
    class Program
    {
        static void Main()
        {
            Priest p = new Priest();

            Warrior w = new Warrior();

            w.Attack(p);
            p.Heal(p);
        }
    }
}
