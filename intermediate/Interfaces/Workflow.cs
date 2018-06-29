using System.Collections.Generic;

namespace Interfaces
{

    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        void Change(IActivity oldActivity, IActivity newActivity);
        IEnumerable<IActivity> GetActivities();
    }
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }
        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }
        public void Change(IActivity oldActivity, IActivity newActivity)
        {
            var index = _activities.IndexOf(oldActivity);
            _activities[index] = newActivity;

        }

        // Enumerable does not allow developer to directly access the private List
        // does not have methods to alter the list
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }

    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}