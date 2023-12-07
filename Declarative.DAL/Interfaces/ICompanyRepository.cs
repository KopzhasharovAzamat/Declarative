using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declarative.DAL.Interfaces
{
    public interface ICompanyRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetValue(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
