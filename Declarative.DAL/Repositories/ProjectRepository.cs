using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

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
            return context.Projects;
        }

        public Project Get(int id)
        {
            return context.Projects.Find(id);
        }

        public void Create(Project book)
        {
            context.Projects.Add(book);
        }

        public void Update(Project book)
        {
            context.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Project> Find(Func<Project, Boolean> predicate)
        {
            return context.Projects.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Project book = context.Projects.Find(id);
            if (book != null)
                context.Projects.Remove(book);
        }

        public Project GetValue(int id)
        {
            throw new NotImplementedException(); // error
        }

        public void Delete(Project item)
        {
            throw new NotImplementedException(); // error
        }
    }
}
