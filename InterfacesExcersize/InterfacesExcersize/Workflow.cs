using System.Collections.Generic;

namespace InterfacesExcersize
{
    public class Workflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities= new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void DisplayAll()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
