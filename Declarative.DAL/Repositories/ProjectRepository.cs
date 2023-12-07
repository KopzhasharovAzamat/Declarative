using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private readonly AppDbContext db;
        public ProjectRepository(AppDbContext context) 
        {
            this.db = context;
        }
        public IEnumerable<Project> GetAll()
        {
            return db.Projects;
        }

        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }

        public void Create(Project book)
        {
            db.Projects.Add(book);
        }

        public void Update(Project book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Project> Find(Func<Project, Boolean> predicate)
        {
            return db.Projects.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Project book = db.Projects.Find(id);
            if (book != null)
                db.Projects.Remove(book);
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
