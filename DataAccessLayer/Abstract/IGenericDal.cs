using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Update(T vrb_t);
        void Delete(T vrb_t);
        void Insert(T vrb_t);
        List<T> GetListAll();
        T GetByID(int id);
    }
}
