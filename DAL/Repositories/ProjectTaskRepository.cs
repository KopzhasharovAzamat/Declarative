using DAL.Entities;
using DAL.EntityFramework;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProjectTaskRepository : IRepository<ProjectTask>
    {
        private context db;
        public ProjectTaskRepository(context context)
        { 
            this.db = context;
        }
        public IEnumerable<ProjectTask> GetAll()
        {
            return db.ProjectTasks.Include(o => o.Phone); // idk
        }
 
        public ProjectTask Get(int id)
        {
            return db.ProjectTasks.Find(id);
        }
 
        public void Create(ProjectTask ProjectTask)
        {
            db.ProjectTasks.Add(ProjectTask);
        }
 
        public void Update(ProjectTask ProjectTask)
        {
            db.Entry(ProjectTask).State = EntityState.Modified;
        }
        public IEnumerable<ProjectTask> Find(Func<ProjectTask, Boolean> predicate)
        {
            return db.ProjectTasks.Include(o => o.Phone).Where(predicate).ToList(); // idk
        }
        public void Delete(int id)
        {
            ProjectTask ProjectTask = db.ProjectTasks.Find(id);
            if (ProjectTask != null)
                db.ProjectTasks.Remove(ProjectTask);
        }

        public ProjectTask GetValue(int id)
        {
            throw new NotImplementedException(); // error
        }

        public void Delete(ProjectTask item)
        {
            throw new NotImplementedException(); // error
        }
    }
}
