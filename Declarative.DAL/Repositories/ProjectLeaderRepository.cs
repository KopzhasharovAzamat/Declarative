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
            return context.ProjectLeaders;
        }

        public ProjectLeader Get(int id)
        {
            return context.ProjectLeaders.Find(id);
        }

        public void Create(ProjectLeader book)
        {
            context.ProjectLeaders.Add(book);
        }

        public void Update(ProjectLeader book)
        {
            //context.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<ProjectLeader> Find(Func<ProjectLeader, Boolean> predicate)
        {
            return context.ProjectLeaders.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ProjectLeader book = context.ProjectLeaders.Find(id);
            if (book != null)
                context.ProjectLeaders.Remove(book);
        }

        public ProjectLeader GetValue(int id)
        {
            throw new NotImplementedException(); // error
        }

        public void Delete(ProjectLeader item)
        {
            throw new NotImplementedException(); // error
        }
    }
}
