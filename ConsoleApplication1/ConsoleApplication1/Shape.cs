namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ConsoleApplication1.Interfaces;

    public class Shape : IMovable
    {
        public ConsoleColor Color { get; set; }

        public double X
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double Y
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Move(double deltaX, double deltaY)
        {
            this.X += deltaX;
            this.Y += deltaY;
        }
    }
}
