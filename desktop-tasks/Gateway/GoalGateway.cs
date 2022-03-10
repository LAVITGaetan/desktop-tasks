using desktop_tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_tasks.Gateway
{
    public class GoalGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public bool Add(Goal goal)
        {
            _dbContext.Goals.Add(goal);
            return _dbContext.SaveChanges()>0;
        }
    }


}
