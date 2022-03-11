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

        public List<Goal> GetAll()
        {
            return _dbContext.Goals.ToList();   
        }

        public bool Update(Goal goal)
        {
            var data = _dbContext.Goals.FirstOrDefault(c => c.Id == goal.Id);
            if (data == null)
            {
                return false;
            }

            data.Title = goal.Title;
            data.Comment = goal.Comment;
            _dbContext.Update(goal);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var goalItem = _dbContext.Goals.FirstOrDefault(c => c.Id == id);
            if (goalItem == null)
            {
                return false;
            }
            _dbContext.Goals.Remove(goalItem);
            return _dbContext.SaveChanges()>0;
        }
    }


}
