using System;

namespace InterfacesExcersize
{
    public class WorkflowEngine
    {
        private readonly Workflow _workflow;

        public WorkflowEngine(Workflow workflow)
        {
            _workflow = workflow;
        }

        public void Run()
        {
            _workflow.DisplayAll();
        }
    }
}
