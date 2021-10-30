using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TAddBL(Category cls_t)
        {
            _categoryDal.Insert(cls_t);
        }

        public void TDeleteBL(Category cls_t)
        {
            _categoryDal.Delete(cls_t);
        }

        public void TUpdateBL(Category cls_t)
        {
            _categoryDal.Update(cls_t);
        }
    }
}
