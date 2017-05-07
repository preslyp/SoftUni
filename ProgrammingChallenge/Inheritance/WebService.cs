namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WebService : WorkflowEngine
    {
        public override void Execute()
        {
            Console.WriteLine("Executing Call Web Service");
        }
    }
}
