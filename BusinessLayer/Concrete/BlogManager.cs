using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategoryBL()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
        public List<Blog> GetBlogWithCategoryByWriter(int id)
        {
           return _blogDal.GetListWithCategoryByWriter(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
             
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public void TAddBL(Blog cls_t)
        {
            _blogDal.Insert(cls_t);
        }

        public void TDeleteBL(Blog cls_t)
        {
            _blogDal.Delete(cls_t);
        }

        public void TUpdateBL(Blog cls_t)
        {
            throw new NotImplementedException();
        }
    }
}
