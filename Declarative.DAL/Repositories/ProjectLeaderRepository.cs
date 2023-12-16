using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class ProjectLeaderRepository : IProjectLeaderRepository<ProjectLeader>
    {
        private readonly AppDbContext context;
        public ProjectLeaderRepository(AppDbContext context) 
        {
            this.context = context;
        }
        public IEnumerable<ProjectLeader> GetAll()
        {
            return context.ProjectLeaders.ToList();
        }
        public ProjectLeader GetById(int id)
        {
            return context.ProjectLeaders.Find(id);
        }
        public void Create(ProjectLeader projectLeader)
        {
            context.ProjectLeaders.Add(projectLeader);
            context.SaveChanges();
        }
        public void Update(ProjectLeader projectLeader)
        {
            context.ProjectLeaders.Update(projectLeader);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            ProjectLeader projectLeader = context.ProjectLeaders.Find(id);
            if (projectLeader != null)
            {
                context.ProjectLeaders.Remove(projectLeader);
                context.SaveChanges();
            }
        }
    }
}
