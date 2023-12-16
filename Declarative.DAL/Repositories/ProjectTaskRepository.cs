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
        public IEnumerable<ProjectTask> GetAll()
        {
            return context.ProjectTasks.ToList();
        }
        public ProjectTask GetById(int id)
        {
            return context.ProjectTasks.Find(id);
        }
        public void Create(ProjectTask projectTask)
        {
            context.ProjectTasks.Add(projectTask);
            context.SaveChanges();
        }
        public void Update(ProjectTask projectTask)
        {
            context.ProjectTasks.Update(projectTask);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            ProjectTask projectTask = context.ProjectTasks.Find(id);
            if (projectTask != null)
            {
                context.ProjectTasks.Remove(projectTask);
                context.SaveChanges();
            }
        }
    }
}
