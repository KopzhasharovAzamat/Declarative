using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class ProjectTaskRepository : IProjectTaskRepository<ProjectTask>
    {
        private readonly AppDbContext context;
        public ProjectTaskRepository(AppDbContext context)
        { 
            this.context = context;
        }

        public IEnumerable<ProjectTask> GetAll() { return context.ProjectTasks; }

        public IEnumerable<ProjectTask> Find(Func<ProjectTask, Boolean> predicate)
        {
            return context.ProjectTasks.Where(predicate).ToList();
        }

        public ProjectTask Get(int id)
        {
            return context.ProjectTasks.Find(id);
        }
 
        public void Create(ProjectTask ProjectTask)
        {
            context.ProjectTasks.Add(ProjectTask);
        }
 
        public void Update(ProjectTask ProjectTask)
        {
            context.Entry(ProjectTask).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            ProjectTask ProjectTask = context.ProjectTasks.Find(id);
            if (ProjectTask != null)
                context.ProjectTasks.Remove(ProjectTask);
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
