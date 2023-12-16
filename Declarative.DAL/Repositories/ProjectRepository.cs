using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;

namespace Declarative.DAL.Repositories
{
    public class ProjectRepository : IProjectRepository<Project>
    {
        private readonly AppDbContext context;
        public ProjectRepository(AppDbContext context) 
        {
            this.context = context;
        }
        public IEnumerable<Project> GetAll()
        {
            return context.Projects.ToList();
        }
        public Project GetById(int id)
        {
            return context.Projects.Find(id);
        }
        public void Create(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
        }
        public void Update(Project project)
        {
            context.Projects.Update(project);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Project project = context.Projects.Find(id);
            if (project != null)
            {
                context.Projects.Remove(project);
                context.SaveChanges();
            }
        }
    }
}
