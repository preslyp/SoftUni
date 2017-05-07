namespace Inheritance
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
            var workFlow = new WorkflowEngine();
            workFlow.AddActivities(new UploadVideo());
            workFlow.AddActivities(new SendEmail());
            workFlow.AddActivities(new WebService());

            workFlow.Run();

            Console.ReadKey();
        }
    }
}
