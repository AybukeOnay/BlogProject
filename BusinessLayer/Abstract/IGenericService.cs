using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAddBL(T cls_t);
        void TDeleteBL(T cls_t);
        void TUpdateBL(T cls_t);
        List<T> GetList();
        T TGetByID(int id);
    }
}
