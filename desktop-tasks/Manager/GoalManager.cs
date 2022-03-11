using desktop_tasks.Gateway;
using desktop_tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_tasks.Manager
{
    public class GoalManager
    {
        GoalGateway _goalGateway = new GoalGateway();

        public bool Add(Goal goal)
        {
            return _goalGateway.Add(goal);
        }

        public List<Goal>GetAll()
        {
            return _goalGateway.GetAll();
        }

        public bool Update(Goal goal)
        {
            return _goalGateway.Update(goal);
        }

        public bool Delete(int id)
        {
            return _goalGateway.Delete(id);
        }
    }
}
