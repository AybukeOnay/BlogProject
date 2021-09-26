using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal :IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
