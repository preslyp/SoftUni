namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WorkflowEngine
    {
        private readonly List<WorkflowEngine> currentActivity;

        public WorkflowEngine()
        {
            this.currentActivity = new List<WorkflowEngine>();
        }

        public void AddActivities(WorkflowEngine activity)
        {
            this.currentActivity.Add(activity);
        }

        public void Run()
        {
            foreach (var act in this.currentActivity)
            {
                act.Execute();
            }
        }

        public virtual void Execute()
        {
        }
    }
}
