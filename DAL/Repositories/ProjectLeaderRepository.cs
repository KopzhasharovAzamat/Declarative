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
    public class ProjectLeaderRepository : IRepository<ProjectLeader>
    {
        private context db;
        public ProjectLeaderRepository(context context) 
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
