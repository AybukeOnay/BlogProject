using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T vrb_t)
        {
            using var c = new Context();
            c.Remove(vrb_t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T vrb_t)
        {
            using var c = new Context();
            c.Add(vrb_t);
            c.SaveChanges();
        }

        public void Update(T vrb_t)
        {
            using var c = new Context();
            c.Update(vrb_t);
            c.SaveChanges();
        }
    }
}
