namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SendEmail : WorkflowEngine
    {
        public override void Execute()
        {
            var numOfEmails = 0;
            Console.WriteLine("How many email do you want to send?");
            numOfEmails = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sending {0} Emails", numOfEmails);
        }
    }
}
