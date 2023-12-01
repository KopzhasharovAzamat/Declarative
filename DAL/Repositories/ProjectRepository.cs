using DAL.Entities;
using DAL.EntityFramework;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private context db;
        public ProjectRepository(context context) 
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
