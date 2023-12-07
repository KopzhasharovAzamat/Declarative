using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class ProjectTaskRepository : IRepository<ProjectTask>
    {
        private readonly AppDbContext db;
        public ProjectTaskRepository(AppDbContext context)
        { 
            this.db = context;
        }
        public IEnumerable<ProjectTask> GetAll()
        {
            return db.ProjectTasks.Include(o => o.Phone); // get rid of Phone
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
            return db.ProjectTasks.Include(o => o.Phone).Where(predicate).ToList(); // get rid of Phone
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
