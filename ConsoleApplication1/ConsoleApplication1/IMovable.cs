using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IMovable
    {
        void Move();
    }

    public class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Walks with 2 legs..");
        }
    }

    public class Cow : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Walks with 4 legs..");
        }
    }
    
    public class Airplane : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Walks with 7 legs..");
        }
    }
}
