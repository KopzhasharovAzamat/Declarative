using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class ProjectLeaderRepository : IRepository<ProjectLeader>
    {
        private readonly AppDbContext db;
        public ProjectLeaderRepository(AppDbContext context) 
        {
            this.db = context;
        }
        public IEnumerable<ProjectLeader> GetAll()
        {
            return db.ProjectLeaders;
        }

        public ProjectLeader Get(int id)
        {
            return db.ProjectLeaders.Find(id);
        }

        public void Create(ProjectLeader book)
        {
            db.ProjectLeaders.Add(book);
        }

        public void Update(ProjectLeader book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<ProjectLeader> Find(Func<ProjectLeader, Boolean> predicate)
        {
            return db.ProjectLeaders.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ProjectLeader book = db.ProjectLeaders.Find(id);
            if (book != null)
                db.ProjectLeaders.Remove(book);
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
