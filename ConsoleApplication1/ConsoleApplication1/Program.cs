using ConsoleApplication1.Interfaces;

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            IMovable shape = new Shape();
            
            IMovable turtle = new Turtle();
        }

        static void Move( IMovable movable, double deltaX, double deltaY)
        {
            movable.Move(deltaX, deltaY);
        }
    }
}
