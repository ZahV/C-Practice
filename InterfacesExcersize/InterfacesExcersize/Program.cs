using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExcersize
{

    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new SendMessage());
            workflow.Add(new SendPorn());
            workflow.Add(new SendPorn());
            workflow.Add(new SendPorn());
            workflow.Add(new SendVideo());

            var workflowEngine = new WorkflowEngine(workflow);

            workflowEngine.Run();
        }
    }
}
