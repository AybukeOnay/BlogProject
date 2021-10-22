using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService 
    {
        void BlogAddBL(Blog blog);
        void BlogDeleteBL(Blog blog);
        void BlogUpdateBL(Blog blog);
        List<Blog> GetList();
        Blog GetByID(int id);
        List<Blog> GetBlogListWithCategoryBL();
        List<Blog> GetBlogListByWriter(int id);
        
    }
}
