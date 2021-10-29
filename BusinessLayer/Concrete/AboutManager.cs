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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }     

        public void TAddBL(About cls_t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(About cls_t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(About cls_t)
        {
            throw new NotImplementedException();
        }
    }
}
